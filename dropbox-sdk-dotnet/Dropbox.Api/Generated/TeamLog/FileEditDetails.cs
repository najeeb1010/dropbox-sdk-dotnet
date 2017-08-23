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
    /// <para>Edited files.</para>
    /// </summary>
    public class FileEditDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileEditDetails> Encoder = new FileEditDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileEditDetails> Decoder = new FileEditDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileEditDetails" />
        /// class.</para>
        /// </summary>
        public FileEditDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileEditDetails" />.</para>
        /// </summary>
        private class FileEditDetailsEncoder : enc.StructEncoder<FileEditDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileEditDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileEditDetails" />.</para>
        /// </summary>
        private class FileEditDetailsDecoder : enc.StructDecoder<FileEditDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileEditDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileEditDetails Create()
            {
                return new FileEditDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileEditDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}