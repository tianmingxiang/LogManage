using System.ComponentModel;

namespace Log.Enum
{
    /// <summary>
    /// 日志等级
    /// </summary>
    public enum LogLevelEnum
    {
        [Description("调试")]
        DEBUG = 1,

        [Description("应用程序的输出")]
        INFO = 2,

        [Description("潜在错误或警告")]
        WARN = 3,

        [Description("错误事件")]
        ERROR = 4,

        [Description("严重错误")]
        FATAL = 5
    }
}
