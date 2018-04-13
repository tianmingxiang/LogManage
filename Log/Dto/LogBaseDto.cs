using Log.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Dto
{
    public class LogBaseDto
    {
        //日志等级
        public LogLevelEnum LogLevelEnum { get; set; }

        //日志类型
        public LogTypeEnum LogTypeEnum { get; set; }

        //平台id
        public int PlatFormId { get; set; }

        //线程id
        public int ThreadId { get; set; }

        //IP地址
        public string IpAddress { get; set; }

        //输出信息
        public string OutMessage { get; set; }

        //添加时间
        public DateTime AddTime { get; set; }
    }
}
