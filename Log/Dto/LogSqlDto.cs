using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Dto
{
    /// <summary>
    /// 日志sql性能实体
    /// </summary>
    public class LogSqlDto: LogBaseDto
    {
        //连接字符串
        public string ConnectionString { get; set; }

        //数据库名称
        public string DataBase { get; set; }

        //执行时间(毫秒)
        public long ExecuteTimes { get; set; }

        //参数
        public IDictionary<string, object> Param { get; set; }


    }
}
