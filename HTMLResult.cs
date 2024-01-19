using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace ASPTest
{
    public class HTMLResult: IActionResult
    {
        string htmlCode;
        public HTMLResult(string html)
        {
            htmlCode = html;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            string fullHtmlCode = @$"<!DOCTYPE html>
            <html>
                <head>
                    <title>Hehe.com</title>
                    <meta charset=utf-8 />
                </head>
                <body>{htmlCode}</body>
            </html>";
            await context.HttpContext.Response.WriteAsync(fullHtmlCode);
        }
    }
}
