using AngleSharp.Parser.Html;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace indeed.com.models
{
    public class Parser
    {
        public async Task<IEnumerable<JobInfo>> Parse(ParserRequest parserRequest)
        {
            HttpClient httpClient = new HttpClient();
            string htmlString = await httpClient.GetStringAsync("https://www.indeed.com/" + parserRequest.ToString());

            var parser = new HtmlParser();
            var doc = parser.Parse(htmlString);

            return null; //TODO  удалить
        }
    }
}
