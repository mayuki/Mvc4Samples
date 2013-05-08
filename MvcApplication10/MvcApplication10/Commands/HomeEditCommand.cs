using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication10.Commands.Messages;

namespace MvcApplication10.Commands
{
    public class HomeEditValidateCommand
    {
        public void Execute(IEditCommandMessage message, ModelStateDictionary modelState)
        {
            if (new[] { "test", "てすと", "テスト" }.Any(x => message.Name.Contains(x)))
                modelState.AddModelError("Name", "名前に test または テスト または てすと を含むことはできません。");
        }
    }
}