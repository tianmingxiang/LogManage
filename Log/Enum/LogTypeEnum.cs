using System.ComponentModel;

namespace Log.Enum
{
    /// <summary>
    /// 日志类型
    /// </summary>
    public enum LogTypeEnum
    {
        [Description("log日志")]
        Log = 1,

        [Description("web性能")]
        WebPerformance = 2,
      
        [Description("sql性能")]
        SqlPerformance = 3
    }
}
