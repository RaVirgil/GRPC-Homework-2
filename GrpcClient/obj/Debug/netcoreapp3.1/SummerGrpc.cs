// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/summer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class SummerSelection
  {
    static readonly string __ServiceName = "SummerSelection";

    static readonly grpc::Marshaller<global::GrpcServer.SummerRequest> __Marshaller_SummerRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.SummerRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.SummerResponse> __Marshaller_SummerResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.SummerResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.SummerRequest, global::GrpcServer.SummerResponse> __Method_SummerSignSelection = new grpc::Method<global::GrpcServer.SummerRequest, global::GrpcServer.SummerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SummerSignSelection",
        __Marshaller_SummerRequest,
        __Marshaller_SummerResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.SummerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for SummerSelection</summary>
    public partial class SummerSelectionClient : grpc::ClientBase<SummerSelectionClient>
    {
      /// <summary>Creates a new client for SummerSelection</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SummerSelectionClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SummerSelection that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SummerSelectionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SummerSelectionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SummerSelectionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServer.SummerResponse SummerSignSelection(global::GrpcServer.SummerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SummerSignSelection(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.SummerResponse SummerSignSelection(global::GrpcServer.SummerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SummerSignSelection, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.SummerResponse> SummerSignSelectionAsync(global::GrpcServer.SummerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SummerSignSelectionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.SummerResponse> SummerSignSelectionAsync(global::GrpcServer.SummerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SummerSignSelection, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SummerSelectionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SummerSelectionClient(configuration);
      }
    }

  }
}
#endregion
