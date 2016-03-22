using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Common
{
    public class GuoLvModelBinder : DefaultModelBinder
    {
        /*
        protected override void SetProperty(ControllerContext controllerContext, ModelBindingContext bindingContext
                                            , PropertyDescriptor propertyDescriptor, object objValue)
        {
            if (propertyDescriptor.PropertyType == typeof(string))
            {
                objValue = (objValue as string).BiaoDanGuoLv();
            }
            else if (propertyDescriptor.PropertyType == typeof(string[]))
            {
                objValue = (objValue as string[]).BiaoDanGuoLv();
            }
            base.SetProperty(controllerContext, bindingContext, propertyDescriptor, objValue);
        }
        */

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var objValue = base.BindModel(controllerContext, bindingContext);

            if (bindingContext.ModelType == typeof(string))
            {
                objValue = (objValue as string).BiaoDanGuoLv();
            }
            else if (bindingContext.ModelType == typeof(string[]))
            {
                objValue = (objValue as string[]).BiaoDanGuoLv();
            }
            return objValue;
        }
    }
}