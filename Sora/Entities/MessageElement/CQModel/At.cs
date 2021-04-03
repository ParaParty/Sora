using Newtonsoft.Json;
using Sora.Converter;

namespace Sora.Entities.MessageElement.CQModel
{
    /// <summary>
    /// At某人
    /// </summary>
    public struct At
    {
        #region 属性

        /// <summary>
        /// At目标UID
        /// 为<see langword="null"/>时为At全体
        /// </summary>
        [JsonConverter(typeof(StringConverter))]
        [JsonProperty(PropertyName = "qq")]
        public string Traget { get; internal set; }

        #endregion
    }
}