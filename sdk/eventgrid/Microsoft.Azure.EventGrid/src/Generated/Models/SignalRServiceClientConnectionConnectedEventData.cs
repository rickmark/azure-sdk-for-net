// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for a
    /// Microsoft.SignalRService.ClientConnectionConnected event.
    /// </summary>
    public partial class SignalRServiceClientConnectionConnectedEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SignalRServiceClientConnectionConnectedEventData class.
        /// </summary>
        public SignalRServiceClientConnectionConnectedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SignalRServiceClientConnectionConnectedEventData class.
        /// </summary>
        /// <param name="timestamp">The time at which the event
        /// occurred.</param>
        /// <param name="hubName">The hub of connected client
        /// connection.</param>
        /// <param name="connectionId">The connection Id of connected client
        /// connection.</param>
        /// <param name="userId">The user Id of connected client
        /// connection.</param>
        public SignalRServiceClientConnectionConnectedEventData(System.DateTime? timestamp = default(System.DateTime?), string hubName = default(string), string connectionId = default(string), string userId = default(string))
        {
            Timestamp = timestamp;
            HubName = hubName;
            ConnectionId = connectionId;
            UserId = userId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time at which the event occurred.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the hub of connected client connection.
        /// </summary>
        [JsonProperty(PropertyName = "hubName")]
        public string HubName { get; set; }

        /// <summary>
        /// Gets or sets the connection Id of connected client connection.
        /// </summary>
        [JsonProperty(PropertyName = "connectionId")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the user Id of connected client connection.
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

    }
}