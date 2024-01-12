using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;

namespace WebClient.Utilities;

public static class HtmlHelperValidationExtensions
{
    public static IHtmlContent RedValidationMessage<TModel, TResult>(
        this IHtmlHelper<TModel> htmlHelper,
        Expression<Func<TModel, TResult>> expression,
        string formName)
    {
        ArgumentNullException.ThrowIfNull(htmlHelper);
        var htmlAttributes = new
        {
            @class = "validation-message text-rose-600",
            data_valmsg_for = formName
        };
        return htmlHelper.ValidationMessageFor(expression, message: null, htmlAttributes: htmlAttributes, tag: null);
    }
}