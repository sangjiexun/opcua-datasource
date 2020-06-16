// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: backend.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Pluginv2 {
  public static partial class Resource
  {
    static readonly string __ServiceName = "pluginv2.Resource";

    static readonly grpc::Marshaller<global::Pluginv2.CallResourceRequest> __Marshaller_pluginv2_CallResourceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.CallResourceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Pluginv2.CallResourceResponse> __Marshaller_pluginv2_CallResourceResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.CallResourceResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Pluginv2.CallResourceRequest, global::Pluginv2.CallResourceResponse> __Method_CallResource = new grpc::Method<global::Pluginv2.CallResourceRequest, global::Pluginv2.CallResourceResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "CallResource",
        __Marshaller_pluginv2_CallResourceRequest,
        __Marshaller_pluginv2_CallResourceResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Pluginv2.BackendReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Resource</summary>
    [grpc::BindServiceMethod(typeof(Resource), "BindService")]
    public abstract partial class ResourceBase
    {
      public virtual global::System.Threading.Tasks.Task CallResource(global::Pluginv2.CallResourceRequest request, grpc::IServerStreamWriter<global::Pluginv2.CallResourceResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Resource</summary>
    public partial class ResourceClient : grpc::ClientBase<ResourceClient>
    {
      /// <summary>Creates a new client for Resource</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ResourceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Resource that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ResourceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ResourceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ResourceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Pluginv2.CallResourceResponse> CallResource(global::Pluginv2.CallResourceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CallResource(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Pluginv2.CallResourceResponse> CallResource(global::Pluginv2.CallResourceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_CallResource, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ResourceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ResourceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ResourceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CallResource, serviceImpl.CallResource).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ResourceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CallResource, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Pluginv2.CallResourceRequest, global::Pluginv2.CallResourceResponse>(serviceImpl.CallResource));
    }

  }
  public static partial class Data
  {
    static readonly string __ServiceName = "pluginv2.Data";

    static readonly grpc::Marshaller<global::Pluginv2.QueryDataRequest> __Marshaller_pluginv2_QueryDataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.QueryDataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Pluginv2.QueryDataResponse> __Marshaller_pluginv2_QueryDataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.QueryDataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse> __Method_QueryData = new grpc::Method<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryData",
        __Marshaller_pluginv2_QueryDataRequest,
        __Marshaller_pluginv2_QueryDataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Pluginv2.BackendReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of Data</summary>
    [grpc::BindServiceMethod(typeof(Data), "BindService")]
    public abstract partial class DataBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Pluginv2.QueryDataResponse> QueryData(global::Pluginv2.QueryDataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Data</summary>
    public partial class DataClient : grpc::ClientBase<DataClient>
    {
      /// <summary>Creates a new client for Data</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DataClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Data that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DataClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DataClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DataClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Pluginv2.QueryDataResponse QueryData(global::Pluginv2.QueryDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pluginv2.QueryDataResponse QueryData(global::Pluginv2.QueryDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueryData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.QueryDataResponse> QueryDataAsync(global::Pluginv2.QueryDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.QueryDataResponse> QueryDataAsync(global::Pluginv2.QueryDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueryData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DataClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DataClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DataBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_QueryData, serviceImpl.QueryData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DataBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_QueryData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse>(serviceImpl.QueryData));
    }

  }
  public static partial class Diagnostics
  {
    static readonly string __ServiceName = "pluginv2.Diagnostics";

    static readonly grpc::Marshaller<global::Pluginv2.CheckHealthRequest> __Marshaller_pluginv2_CheckHealthRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.CheckHealthRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Pluginv2.CheckHealthResponse> __Marshaller_pluginv2_CheckHealthResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.CheckHealthResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Pluginv2.CollectMetricsRequest> __Marshaller_pluginv2_CollectMetricsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.CollectMetricsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Pluginv2.CollectMetricsResponse> __Marshaller_pluginv2_CollectMetricsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.CollectMetricsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Pluginv2.CheckHealthRequest, global::Pluginv2.CheckHealthResponse> __Method_CheckHealth = new grpc::Method<global::Pluginv2.CheckHealthRequest, global::Pluginv2.CheckHealthResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckHealth",
        __Marshaller_pluginv2_CheckHealthRequest,
        __Marshaller_pluginv2_CheckHealthResponse);

    static readonly grpc::Method<global::Pluginv2.CollectMetricsRequest, global::Pluginv2.CollectMetricsResponse> __Method_CollectMetrics = new grpc::Method<global::Pluginv2.CollectMetricsRequest, global::Pluginv2.CollectMetricsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CollectMetrics",
        __Marshaller_pluginv2_CollectMetricsRequest,
        __Marshaller_pluginv2_CollectMetricsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Pluginv2.BackendReflection.Descriptor.Services[2]; }
    }

    /// <summary>Base class for server-side implementations of Diagnostics</summary>
    [grpc::BindServiceMethod(typeof(Diagnostics), "BindService")]
    public abstract partial class DiagnosticsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Pluginv2.CheckHealthResponse> CheckHealth(global::Pluginv2.CheckHealthRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Pluginv2.CollectMetricsResponse> CollectMetrics(global::Pluginv2.CollectMetricsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Diagnostics</summary>
    public partial class DiagnosticsClient : grpc::ClientBase<DiagnosticsClient>
    {
      /// <summary>Creates a new client for Diagnostics</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DiagnosticsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Diagnostics that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DiagnosticsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DiagnosticsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DiagnosticsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Pluginv2.CheckHealthResponse CheckHealth(global::Pluginv2.CheckHealthRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckHealth(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pluginv2.CheckHealthResponse CheckHealth(global::Pluginv2.CheckHealthRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckHealth, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.CheckHealthResponse> CheckHealthAsync(global::Pluginv2.CheckHealthRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckHealthAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.CheckHealthResponse> CheckHealthAsync(global::Pluginv2.CheckHealthRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckHealth, null, options, request);
      }
      public virtual global::Pluginv2.CollectMetricsResponse CollectMetrics(global::Pluginv2.CollectMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CollectMetrics(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pluginv2.CollectMetricsResponse CollectMetrics(global::Pluginv2.CollectMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CollectMetrics, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.CollectMetricsResponse> CollectMetricsAsync(global::Pluginv2.CollectMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CollectMetricsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.CollectMetricsResponse> CollectMetricsAsync(global::Pluginv2.CollectMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CollectMetrics, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DiagnosticsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DiagnosticsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DiagnosticsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CheckHealth, serviceImpl.CheckHealth)
          .AddMethod(__Method_CollectMetrics, serviceImpl.CollectMetrics).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DiagnosticsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CheckHealth, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pluginv2.CheckHealthRequest, global::Pluginv2.CheckHealthResponse>(serviceImpl.CheckHealth));
      serviceBinder.AddMethod(__Method_CollectMetrics, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pluginv2.CollectMetricsRequest, global::Pluginv2.CollectMetricsResponse>(serviceImpl.CollectMetrics));
    }

  }
  public static partial class Transform
  {
    static readonly string __ServiceName = "pluginv2.Transform";

    static readonly grpc::Marshaller<global::Pluginv2.QueryDataRequest> __Marshaller_pluginv2_QueryDataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.QueryDataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Pluginv2.QueryDataResponse> __Marshaller_pluginv2_QueryDataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.QueryDataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse> __Method_TransformData = new grpc::Method<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TransformData",
        __Marshaller_pluginv2_QueryDataRequest,
        __Marshaller_pluginv2_QueryDataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Pluginv2.BackendReflection.Descriptor.Services[3]; }
    }

    /// <summary>Base class for server-side implementations of Transform</summary>
    [grpc::BindServiceMethod(typeof(Transform), "BindService")]
    public abstract partial class TransformBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Pluginv2.QueryDataResponse> TransformData(global::Pluginv2.QueryDataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Transform</summary>
    public partial class TransformClient : grpc::ClientBase<TransformClient>
    {
      /// <summary>Creates a new client for Transform</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TransformClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Transform that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TransformClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TransformClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TransformClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Pluginv2.QueryDataResponse TransformData(global::Pluginv2.QueryDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TransformData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pluginv2.QueryDataResponse TransformData(global::Pluginv2.QueryDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_TransformData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.QueryDataResponse> TransformDataAsync(global::Pluginv2.QueryDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TransformDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.QueryDataResponse> TransformDataAsync(global::Pluginv2.QueryDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_TransformData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TransformClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TransformClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TransformBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_TransformData, serviceImpl.TransformData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TransformBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_TransformData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse>(serviceImpl.TransformData));
    }

  }
  public static partial class TransformDataCallBack
  {
    static readonly string __ServiceName = "pluginv2.TransformDataCallBack";

    static readonly grpc::Marshaller<global::Pluginv2.QueryDataRequest> __Marshaller_pluginv2_QueryDataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.QueryDataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Pluginv2.QueryDataResponse> __Marshaller_pluginv2_QueryDataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Pluginv2.QueryDataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse> __Method_QueryData = new grpc::Method<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryData",
        __Marshaller_pluginv2_QueryDataRequest,
        __Marshaller_pluginv2_QueryDataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Pluginv2.BackendReflection.Descriptor.Services[4]; }
    }

    /// <summary>Base class for server-side implementations of TransformDataCallBack</summary>
    [grpc::BindServiceMethod(typeof(TransformDataCallBack), "BindService")]
    public abstract partial class TransformDataCallBackBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Pluginv2.QueryDataResponse> QueryData(global::Pluginv2.QueryDataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TransformDataCallBack</summary>
    public partial class TransformDataCallBackClient : grpc::ClientBase<TransformDataCallBackClient>
    {
      /// <summary>Creates a new client for TransformDataCallBack</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TransformDataCallBackClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TransformDataCallBack that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TransformDataCallBackClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TransformDataCallBackClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TransformDataCallBackClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Pluginv2.QueryDataResponse QueryData(global::Pluginv2.QueryDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Pluginv2.QueryDataResponse QueryData(global::Pluginv2.QueryDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueryData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.QueryDataResponse> QueryDataAsync(global::Pluginv2.QueryDataRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Pluginv2.QueryDataResponse> QueryDataAsync(global::Pluginv2.QueryDataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueryData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TransformDataCallBackClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TransformDataCallBackClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TransformDataCallBackBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_QueryData, serviceImpl.QueryData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TransformDataCallBackBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_QueryData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Pluginv2.QueryDataRequest, global::Pluginv2.QueryDataResponse>(serviceImpl.QueryData));
    }

  }
}
#endregion
