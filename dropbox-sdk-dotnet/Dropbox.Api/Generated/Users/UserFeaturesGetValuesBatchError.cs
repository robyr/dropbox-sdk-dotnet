// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The user features get values batch error object</para>
    /// </summary>
    public class UserFeaturesGetValuesBatchError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserFeaturesGetValuesBatchError> Encoder = new UserFeaturesGetValuesBatchErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserFeaturesGetValuesBatchError> Decoder = new UserFeaturesGetValuesBatchErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserFeaturesGetValuesBatchError"
        /// /> class.</para>
        /// </summary>
        public UserFeaturesGetValuesBatchError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is EmptyFeaturesList</para>
        /// </summary>
        public bool IsEmptyFeaturesList
        {
            get
            {
                return this is EmptyFeaturesList;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a EmptyFeaturesList, or <c>null</c>.</para>
        /// </summary>
        public EmptyFeaturesList AsEmptyFeaturesList
        {
            get
            {
                return this as EmptyFeaturesList;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UserFeaturesGetValuesBatchError" />.</para>
        /// </summary>
        private class UserFeaturesGetValuesBatchErrorEncoder : enc.StructEncoder<UserFeaturesGetValuesBatchError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserFeaturesGetValuesBatchError value, enc.IJsonWriter writer)
            {
                if (value is EmptyFeaturesList)
                {
                    WriteProperty(".tag", "empty_features_list", writer, enc.StringEncoder.Instance);
                    EmptyFeaturesList.Encoder.EncodeFields((EmptyFeaturesList)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UserFeaturesGetValuesBatchError" />.</para>
        /// </summary>
        private class UserFeaturesGetValuesBatchErrorDecoder : enc.UnionDecoder<UserFeaturesGetValuesBatchError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserFeaturesGetValuesBatchError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserFeaturesGetValuesBatchError Create()
            {
                return new UserFeaturesGetValuesBatchError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override UserFeaturesGetValuesBatchError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "empty_features_list":
                        return EmptyFeaturesList.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>At least one <see cref="UserFeature" /> must be included in the <see
        /// cref="UserFeaturesGetValuesBatchArg" />.features list.</para>
        /// </summary>
        public sealed class EmptyFeaturesList : UserFeaturesGetValuesBatchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<EmptyFeaturesList> Encoder = new EmptyFeaturesListEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<EmptyFeaturesList> Decoder = new EmptyFeaturesListDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="EmptyFeaturesList" />
            /// class.</para>
            /// </summary>
            private EmptyFeaturesList()
            {
            }

            /// <summary>
            /// <para>A singleton instance of EmptyFeaturesList</para>
            /// </summary>
            public static readonly EmptyFeaturesList Instance = new EmptyFeaturesList();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="EmptyFeaturesList" />.</para>
            /// </summary>
            private class EmptyFeaturesListEncoder : enc.StructEncoder<EmptyFeaturesList>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(EmptyFeaturesList value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="EmptyFeaturesList" />.</para>
            /// </summary>
            private class EmptyFeaturesListDecoder : enc.StructDecoder<EmptyFeaturesList>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="EmptyFeaturesList"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override EmptyFeaturesList Create()
                {
                    return EmptyFeaturesList.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : UserFeaturesGetValuesBatchError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}