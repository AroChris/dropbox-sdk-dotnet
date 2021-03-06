// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Enabled or disabled file requests.</para>
    /// </summary>
    public class FileRequestsChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileRequestsChangePolicyDetails> Encoder = new FileRequestsChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileRequestsChangePolicyDetails> Decoder = new FileRequestsChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestsChangePolicyDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="newValue">New file requests policy.</param>
        /// <param name="previousValue">Previous file requests policy. Might be missing due to
        /// historical data gap.</param>
        public FileRequestsChangePolicyDetails(FileRequestsPolicy newValue,
                                               FileRequestsPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestsChangePolicyDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileRequestsChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New file requests policy.</para>
        /// </summary>
        public FileRequestsPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous file requests policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public FileRequestsPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileRequestsChangePolicyDetails" />.</para>
        /// </summary>
        private class FileRequestsChangePolicyDetailsEncoder : enc.StructEncoder<FileRequestsChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileRequestsChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.FileRequestsPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.FileRequestsPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileRequestsChangePolicyDetails" />.</para>
        /// </summary>
        private class FileRequestsChangePolicyDetailsDecoder : enc.StructDecoder<FileRequestsChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileRequestsChangePolicyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileRequestsChangePolicyDetails Create()
            {
                return new FileRequestsChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileRequestsChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.FileRequestsPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.FileRequestsPolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
