import React, { PureComponent } from 'react';
import { CascaderOption } from 'rc-cascader/lib/Cascader';
import { EventColumn, EventFilter, QualifiedName, OpcUaBrowseResults, OpcUaQuery, OpcUaDataSourceOptions, separator} from '../types';
import { AddEventFieldForm } from './AddEventFieldForm';
import { EventFieldTable } from './EventFieldTable';
import { EventFilterTable } from './EventFilterTable';
import { AddEventFilter } from './AddEventFilter';
import { SegmentFrame } from './SegmentFrame';
import { ButtonCascader } from './ButtonCascader/ButtonCascader';
import { copyEventFilter, createFilterTree, serializeEventFilter, deserializeEventFilters } from '../utils/EventFilter';
import { copyEventColumn } from '../utils/EventColumn';
import { toCascaderOption } from '../utils/CascaderOption';
import { DataSource } from '../DataSource';
import { QueryEditorProps } from '@grafana/data';

type Props = QueryEditorProps<DataSource, OpcUaQuery, OpcUaDataSourceOptions>;

type State = {
   
    eventTypeNodeId: string;
    eventOptions: CascaderOption[];
    eventTypes: string[];
    eventFields: EventColumn[];
    eventFilters: EventFilter[];

};

const eventTypesNode = "i=3048";

export class EventQueryEditor extends PureComponent<Props, State> {

    constructor(props: Props) {
        super(props);
        // Better way of doing initialization from props??
        let evtype = this.props?.query?.eventQuery?.eventTypes;
        if (typeof evtype === 'undefined')
            evtype = [];

        let eventTypeNodeId = this.props.query?.eventQuery?.eventTypeNodeId;
        let removeFirstEventFilter = true; // First event filter from props is event type node.
        if (typeof eventTypeNodeId === 'undefined') {
            eventTypeNodeId = "";
            removeFirstEventFilter = false;
        }
        let evFilters = this.props.query?.eventQuery?.eventFilters;
        if (typeof evFilters === 'undefined') {
            evFilters = [];
        }
        if (evFilters.length > 0 && removeFirstEventFilter)
            evFilters = evFilters.slice(1, evFilters.length);

        this.state = {
            eventTypes: evtype,
            eventOptions: [],
            eventFields: this.buildEventFields(this.props.query?.eventQuery?.eventColumns),
            eventTypeNodeId: eventTypeNodeId,
            eventFilters: deserializeEventFilters(evFilters),
        };



        props.datasource.getResource('browseTypes', { nodeId: eventTypesNode }).then((results: OpcUaBrowseResults[]) => {
            console.log('Results', results);
            this.setState({
                eventOptions: results.map((r: OpcUaBrowseResults) => toCascaderOption(r)),
            });
        });
    }

    onChangeEventType = (selected: string[], selectedItems: CascaderOption[]) => {
        const evtTypes = selectedItems.map(item => (item.label ? item.label.toString() : ''));
        const nid = selected[selected.length - 1];
        this.setState({ eventTypeNodeId: nid, eventTypes: evtTypes }, () => this.updateEventQuery());
    };


    buildEventFields = (storedEventColumns: EventColumn[]): EventColumn[] => {
        if (typeof storedEventColumns === 'undefined') {
            return [
                { alias: "", browsename: { name: "Time", namespaceUrl: "" } },
                { alias: "", browsename: { name: "EventId", namespaceUrl: "" } },
                { alias: "", browsename: { name: "EventType", namespaceUrl: "" } },
                { alias: "", browsename: { name: "SourceName", namespaceUrl: "" } },
                { alias: "", browsename: { name: "Message", namespaceUrl: "" } },
                { alias: "", browsename: { name: "Severity", namespaceUrl: "" } }
            ];
        }
        return storedEventColumns.map(a => copyEventColumn(a));
    }


    getEventTypes = (selectedOptions: CascaderOption[]) => {
        const targetOption = selectedOptions[selectedOptions.length - 1];
        targetOption.loading = true;
        if (targetOption.value) {
            this.props.datasource
                .getResource('browseTypes', { nodeId: targetOption.value })
                .then((results: OpcUaBrowseResults[]) => {
                    targetOption.loading = false;
                    targetOption.children = results.map(r => toCascaderOption(r));
                    this.setState({
                        eventOptions: [...this.state.eventOptions],
                    });
                });
        }
    };

    handleDeleteSelectField = (idx: number) => {
        let tempArray = this.state.eventFields.map(a => copyEventColumn(a));
        tempArray.splice(idx, 1);
        this.setState({ eventFields: tempArray }, () => this.updateEventQuery());
    }

    handleDeleteEventFilter = (idx: number) => {
        let tempArray = this.state.eventFilters.map(a => copyEventFilter(a));
        tempArray.splice(idx, 1);
        this.setState({ eventFilters: tempArray }, () => this.updateEventQuery());
    }


    updateEventQuery = () => {
        const { query, onChange, onRunQuery } = this.props;

        let eventColumns = this.state.eventFields.map(c => copyEventColumn(c));
        let evtTypes = this.state.eventTypes;
        let nid = this.state.eventTypeNodeId;
        let eventFilters = createFilterTree(this.state.eventTypeNodeId, this.state.eventFilters).map(x => serializeEventFilter(x));

        let eventQuery = {
            eventTypeNodeId: nid,
            eventTypes: evtTypes,
            eventColumns: eventColumns,
            eventFilters: eventFilters
        }
        onChange({
            ...query,
            eventQuery: eventQuery
        });
        onRunQuery();
    }

    addSelectField = (browsename: QualifiedName, alias: string) => {
        let tempArray = this.state.eventFields.slice();

        tempArray.push({ browsename: { name: browsename.name, namespaceUrl: browsename.namespaceUrl }, alias: alias });
        this.setState({ eventFields: tempArray }, () => this.updateEventQuery());
    }

    addEventFilter = (eventFilter: EventFilter) => {
        let tempArray = this.state.eventFilters.slice();
        tempArray.push(eventFilter);
        this.setState({ eventFilters: tempArray }, () => this.updateEventQuery());
    }


    render() {
        
        return (
            <>
                <SegmentFrame label="Event Type" >
                    <ButtonCascader
                        //className="query-part"
                        value={this.state.eventTypes}
                        loadData={this.getEventTypes}
                        options={this.state.eventOptions}
                        onChange={this.onChangeEventType}
                    >
                        {this.state.eventTypes.join(separator)}
                    </ButtonCascader>
                </SegmentFrame>
                <br />
                <EventFieldTable rows={this.state.eventFields} ondelete={(idx: number) => this.handleDeleteSelectField(idx)} />
                <br />
                <AddEventFieldForm add={(browsename: QualifiedName, alias: string) => this.addSelectField(browsename, alias)} />
                <br />
                <EventFilterTable rows={this.state.eventFilters} ondelete={(idx: number) => { this.handleDeleteEventFilter(idx) }} />
                <br />
                <AddEventFilter add={(eventFilter: EventFilter) => { this.addEventFilter(eventFilter) }} />

            </>
        );
    }
}