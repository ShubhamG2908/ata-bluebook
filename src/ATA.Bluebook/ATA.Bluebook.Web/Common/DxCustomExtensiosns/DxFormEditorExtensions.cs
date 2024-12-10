using ATA.Bluebook.Web.Models;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Factories;

using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace ATA.Bluebook.Web.Common.DxCustomExtensiosns
{
    public static class DxFormEditorExtensions
    {
        private static string GetCustomDxFiledName(string value) => $"dx-custom-{value}-field";

        /// <summary>
        /// Create a Password Field for FormItemEditorFactorty
        /// </summary>
        /// <typeparam name="TFormData">Represent the FormData</typeparam>
        /// <param name="factory">Instace of FormItemsFactory<TFormData></param>
        /// <param name="expression">Expression indicating the member of class<TFormData></param>
        /// <param name="controlName">controlName for the control. Default value will be 'Password'</param>
        /// <param name="iconBtnId">Id of the Icon Button for the control. Default value will be 'hide-show-password-btn'</param>
        /// <returns></returns>
        public static void AddCustomFormPassword<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression, string controlName = "Password", string iconBtnId = "hide-show-password-btn")
        {
            factory.AddSimpleFor(expression)
                .Editor(e => e.TextBox()
                                    .Mode(TextBoxMode.Password)
                                    .Height(40)

                                    .ValidationMessageMode(ValidationMessageMode.Always)
                                    .ValidationMessagePosition(Position.Bottom)
                                    .Buttons(btn =>
                                                        btn.Add()
                                                        .Name(GetCustomDxFiledName(controlName))
                                                        .Location(TextEditorButtonLocation.After)
                                                        .Widget(w => w.Button()
                                                                .ID(iconBtnId)
                                                                .Type(ButtonType.Default)
                                                                .Icon("eyeopen")
                                                                .StylingMode(ButtonStylingMode.Text)
                                                                .OnClick($"() => changePasswordMode('{controlName}','{iconBtnId}')")))).CssClass("my-2");
        }

        public static void AddCustomFormTextBox<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression)
        {
            factory.AddSimpleFor(expression)
                .Editor(e => e.TextBox()
                                        .Height(40)
                                        .ValidationMessageMode(ValidationMessageMode.Always)
                                        .ValidationMessagePosition(Position.Bottom)).CssClass("my-2");
        }

        public static void AddCustomFormHyperLink<TFormData>(this FormItemsFactory<TFormData> factory, string url, string text, string CssClass = "")
        {
            factory.AddSimple().Template($"<a href=\"{url}\">{text}</a>").CssClass(CssClass);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TFormData">Represent the FormData</typeparam>
        /// <param name="factory">Instace of FormItemsFactory<TFormData></param>
        /// <param name="text">Button Text</param>
        /// <param name="width">Width of the Button</param>
        /// <param name="type">Button style</param>
        /// <param name="canSubmitForm">true if button is allow to submit form. Default value is false</param>
        public static void AddCustomFormButton<TFormData>(this FormItemsFactory<TFormData> factory, string text, string width, ButtonType type = ButtonType.Default, bool canSubmitForm = false)
        {
            factory.AddButton().Name(GetCustomDxFiledName(text))
                    .ButtonOptions(cfg =>
                    {
                        cfg.StylingMode(ButtonStylingMode.Contained);
                        cfg.Text(text);
                        cfg.Width(width);
                        cfg.Type(type);
                        cfg.Height(40);
                        if (canSubmitForm)
                        {
                            cfg.UseSubmitBehavior(true);
                        }
                    });
        }

        public static void AddCustomFormSelectBox<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression, string controller, string action, string keyField, string displayField, string valueChangeCallBack, DataSourceLoadMode loadMode = DataSourceLoadMode.Raw)
        {
            factory.AddSimpleFor(expression)
                .Editor(e => e.SelectBox()
                                .ValueExpr(keyField)
                                .DataSource(d => d.Mvc()
                                                .Controller(controller)
                                                .LoadAction(action)
                                                .LoadMode(loadMode)
                                                .Key(keyField))
                                .Height(40)
                                .DisplayExpr(displayField)
                                .OnValueChanged(valueChangeCallBack)
                                .ValidationMessageMode(ValidationMessageMode.Always)
                                .ValidationMessagePosition(Position.Bottom)
                );
        }

    }
}
