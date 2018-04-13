namespace Log.Dto
{
    /// <summary>
    /// 日志web性能实体
    /// </summary>
    public class LogWebDto : LogBaseDto
    {
        //接口地址
        public string WebUrl { get; set; }
    }
}
