// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Sets the promote mode for a replica server. This is a write only property. </summary>
    public readonly partial struct ReadReplicaPromoteMode : IEquatable<ReadReplicaPromoteMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReadReplicaPromoteMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReadReplicaPromoteMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandaloneValue = "standalone";
        private const string SwitchoverValue = "switchover";

        /// <summary> standalone. </summary>
        public static ReadReplicaPromoteMode Standalone { get; } = new ReadReplicaPromoteMode(StandaloneValue);
        /// <summary> switchover. </summary>
        public static ReadReplicaPromoteMode Switchover { get; } = new ReadReplicaPromoteMode(SwitchoverValue);
        /// <summary> Determines if two <see cref="ReadReplicaPromoteMode"/> values are the same. </summary>
        public static bool operator ==(ReadReplicaPromoteMode left, ReadReplicaPromoteMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReadReplicaPromoteMode"/> values are not the same. </summary>
        public static bool operator !=(ReadReplicaPromoteMode left, ReadReplicaPromoteMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ReadReplicaPromoteMode"/>. </summary>
        public static implicit operator ReadReplicaPromoteMode(string value) => new ReadReplicaPromoteMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReadReplicaPromoteMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReadReplicaPromoteMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
