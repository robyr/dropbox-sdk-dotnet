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
    /// <para>Changed who can become a member of the shared folder.</para>
    /// </summary>
    public class SharedFolderChangeMemberPolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderChangeMemberPolicyDetails> Encoder = new SharedFolderChangeMemberPolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderChangeMemberPolicyDetails> Decoder = new SharedFolderChangeMemberPolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeMemberPolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="targetAssetIndex">Target asset position in the Assets list.</param>
        /// <param name="originalFolderName">Original shared folder name.</param>
        /// <param name="newValue">New external invite policy.</param>
        /// <param name="sharedFolderType">Shared folder type. Might be missing due to
        /// historical data gap.</param>
        /// <param name="previousValue">Previous external invite policy. Might be missing due
        /// to historical data gap.</param>
        public SharedFolderChangeMemberPolicyDetails(ulong targetAssetIndex,
                                                     string originalFolderName,
                                                     SharedFolderMemberPolicy newValue,
                                                     string sharedFolderType = null,
                                                     SharedFolderMemberPolicy previousValue = null)
        {
            if (originalFolderName == null)
            {
                throw new sys.ArgumentNullException("originalFolderName");
            }

            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.TargetAssetIndex = targetAssetIndex;
            this.OriginalFolderName = originalFolderName;
            this.NewValue = newValue;
            this.SharedFolderType = sharedFolderType;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeMemberPolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFolderChangeMemberPolicyDetails()
        {
        }

        /// <summary>
        /// <para>Target asset position in the Assets list.</para>
        /// </summary>
        public ulong TargetAssetIndex { get; protected set; }

        /// <summary>
        /// <para>Original shared folder name.</para>
        /// </summary>
        public string OriginalFolderName { get; protected set; }

        /// <summary>
        /// <para>New external invite policy.</para>
        /// </summary>
        public SharedFolderMemberPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Shared folder type. Might be missing due to historical data gap.</para>
        /// </summary>
        public string SharedFolderType { get; protected set; }

        /// <summary>
        /// <para>Previous external invite policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public SharedFolderMemberPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderChangeMemberPolicyDetails" />.</para>
        /// </summary>
        private class SharedFolderChangeMemberPolicyDetailsEncoder : enc.StructEncoder<SharedFolderChangeMemberPolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderChangeMemberPolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_asset_index", value.TargetAssetIndex, writer, enc.UInt64Encoder.Instance);
                WriteProperty("original_folder_name", value.OriginalFolderName, writer, enc.StringEncoder.Instance);
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.SharedFolderMemberPolicy.Encoder);
                if (value.SharedFolderType != null)
                {
                    WriteProperty("shared_folder_type", value.SharedFolderType, writer, enc.StringEncoder.Instance);
                }
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.SharedFolderMemberPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderChangeMemberPolicyDetails" />.</para>
        /// </summary>
        private class SharedFolderChangeMemberPolicyDetailsDecoder : enc.StructDecoder<SharedFolderChangeMemberPolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedFolderChangeMemberPolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderChangeMemberPolicyDetails Create()
            {
                return new SharedFolderChangeMemberPolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderChangeMemberPolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_asset_index":
                        value.TargetAssetIndex = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "original_folder_name":
                        value.OriginalFolderName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.SharedFolderMemberPolicy.Decoder.Decode(reader);
                        break;
                    case "shared_folder_type":
                        value.SharedFolderType = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.SharedFolderMemberPolicy.Decoder.Decode(reader);
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