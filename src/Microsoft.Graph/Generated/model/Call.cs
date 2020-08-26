// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Call.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Call : Entity
    {
    
		///<summary>
		/// The Call constructor
		///</summary>
        public Call()
        {
            this.ODataType = "microsoft.graph.call";
        }
	
        /// <summary>
        /// Gets or sets state.
        /// The call state. Possible values are: incoming, establishing, ringing, established, hold, transferring, transferAccepted, redirecting, terminating, terminated. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public CallState? State { get; set; }
    
        /// <summary>
        /// Gets or sets media state.
        /// Read-only. The call media state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaState", Required = Newtonsoft.Json.Required.Default)]
        public CallMediaState MediaState { get; set; }
    
        /// <summary>
        /// Gets or sets result info.
        /// The result information. For example can hold termination reason. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resultInfo", Required = Newtonsoft.Json.Required.Default)]
        public ResultInfo ResultInfo { get; set; }
    
        /// <summary>
        /// Gets or sets direction.
        /// The direction of the call. The possible value are incoming or outgoing. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "direction", Required = Newtonsoft.Json.Required.Default)]
        public CallDirection? Direction { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The subject of the conversation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets callback uri.
        /// The callback URL on which callbacks will be delivered. Must be https.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "callbackUri", Required = Newtonsoft.Json.Required.Default)]
        public string CallbackUri { get; set; }
    
        /// <summary>
        /// Gets or sets call routes.
        /// The routing information on how the call was retargeted. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "callRoutes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<CallRoute> CallRoutes { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// The originator of the call.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source", Required = Newtonsoft.Json.Required.Default)]
        public ParticipantInfo Source { get; set; }
    
        /// <summary>
        /// Gets or sets targets.
        /// The targets of the call. Required information for creating peer to peer call.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targets", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<InvitationParticipantInfo> Targets { get; set; }
    
        /// <summary>
        /// Gets or sets requested modalities.
        /// The list of requested modalities. Possible values are: unknown, audio, video, videoBasedScreenSharing, data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestedModalities", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Modality> RequestedModalities { get; set; }
    
        /// <summary>
        /// Gets or sets media config.
        /// The media configuration. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaConfig", Required = Newtonsoft.Json.Required.Default)]
        public MediaConfig MediaConfig { get; set; }
    
        /// <summary>
        /// Gets or sets chat info.
        /// The chat information. Required information for joining a meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "chatInfo", Required = Newtonsoft.Json.Required.Default)]
        public ChatInfo ChatInfo { get; set; }
    
        /// <summary>
        /// Gets or sets call options.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "callOptions", Required = Newtonsoft.Json.Required.Default)]
        public CallOptions CallOptions { get; set; }
    
        /// <summary>
        /// Gets or sets meeting info.
        /// The meeting information that's required for joining a meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetingInfo", Required = Newtonsoft.Json.Required.Default)]
        public MeetingInfo MeetingInfo { get; set; }
    
        /// <summary>
        /// Gets or sets transcription.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transcription", Required = Newtonsoft.Json.Required.Default)]
        public CallTranscriptionInfo Transcription { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantId", Required = Newtonsoft.Json.Required.Default)]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets my participant id.
        /// Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "myParticipantId", Required = Newtonsoft.Json.Required.Default)]
        public string MyParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets tone info.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "toneInfo", Required = Newtonsoft.Json.Required.Default)]
        public ToneInfo ToneInfo { get; set; }
    
        /// <summary>
        /// Gets or sets call chain id.
        /// A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "callChainId", Required = Newtonsoft.Json.Required.Default)]
        public string CallChainId { get; set; }
    
        /// <summary>
        /// Gets or sets incoming context.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "incomingContext", Required = Newtonsoft.Json.Required.Default)]
        public IncomingContext IncomingContext { get; set; }
    
        /// <summary>
        /// Gets or sets participants.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participants", Required = Newtonsoft.Json.Required.Default)]
        public ICallParticipantsCollectionPage Participants { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operations", Required = Newtonsoft.Json.Required.Default)]
        public ICallOperationsCollectionPage Operations { get; set; }
    
    }
}

