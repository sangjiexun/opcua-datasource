import React, { PureComponent } from "react";
import { OpcUaBrowseResults, OpcUaNodeInfo, QualifiedName, NodePath } from '../types';
import { Button } from '@grafana/ui';
import { Browser } from './Browser';
import { NodeTextEditor } from './NodeTextEditor';

type Props = {
    rootNodeId: string,
    node: NodePath,
    browse(nodeId: string): Promise<OpcUaBrowseResults[]>;
    onChangeNode(node: NodePath): void;
    readNode(nodeId: string): Promise<OpcUaNodeInfo>;
    placeholder: string;
};


type State = {
    node: OpcUaNodeInfo,
    browserOpened: boolean,
}

export class NodeEditor extends PureComponent<Props, State> {

    constructor(props: Props) {
        super(props);
        this.state = {
            browserOpened: false, node: {
                browseName: { name: "", namespaceUrl: "" }, displayName: "", nodeClass: -1, nodeId: ""
            }
        };
    }

    toggleBrowser = () => {
        this.setState({ browserOpened: !this.state.browserOpened });
    }

    renderNodeBrowser = (rootNodeId: OpcUaBrowseResults) => {
        if (this.state.browserOpened) {
            return <div data-id="Treeview-MainDiv" style={{
                border: "lightgrey 1px solid",
                borderRadius: "1px",
                cursor: "pointer",
                padding: "2px",
                position: "absolute",
                left: 30,
                top: 10,
                zIndex: 10,
            }}>
                <Browser closeBrowser={() => this.setState({ browserOpened: false })} closeOnSelect={true}
                    browse={a => this.props.browse(a)}
                    ignoreRootNode={true} rootNodeId={rootNodeId}
                    onNodeSelectedChanged={(node, browsepath) => { this.onChangeNode(node, browsepath) }}></Browser></div>;
        }
        return <></>;
    }


    onChangeNode(node: OpcUaNodeInfo, path: QualifiedName[]) {
        var nodePath: NodePath = { node: node, browsePath: path };
        this.setState({ node: node }, () => this.props.onChangeNode(nodePath));
    }


    render() {
        let rootNodeId: OpcUaBrowseResults = {
            browseName: { name: "", namespaceUrl: "" }, displayName: "", isForward: true, nodeClass: 0, nodeId: this.props.rootNodeId
        };
        return <div className="gf-form-inline"><NodeTextEditor placeholder={this.props.placeholder} readNode={(s) => this.props.readNode(s)} node={this.props.node} /*onNodeChanged={(n: OpcUaNodeInfo) => this.onChangeNode(n)}*/ />
            <Button onClick={() => this.toggleBrowser()}>Browse</Button>
            <div style={{ position: 'relative' }}>
                {this.renderNodeBrowser(rootNodeId)}
            </div></div>;

    }
}


