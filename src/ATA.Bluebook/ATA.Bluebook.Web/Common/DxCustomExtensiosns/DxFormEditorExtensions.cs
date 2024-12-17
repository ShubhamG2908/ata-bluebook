using ATA.Bluebook.Web.Common.DxCustomExtensiosns.Configs;
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

        public static void AddCustomFormSelectBox<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression, SelectionControlConfig config)
        {
            factory.AddSimpleFor(expression)
                .Editor(e => e.SelectBox()
                                .ValueExpr(config.KeyField)
                                .DataSource(d => d.Mvc()
                                                .Controller(config.DbSourceController)
                                                .LoadAction(config.DBSourceAction)
                                                .LoadMode(config.LoadMode)
                                                .Key(config.KeyField))
                                .Height(40)
                                .DisplayExpr(config.DisplayField)
                                .OnValueChanged(config.ValueChangeCallBack)
                                .ValidationMessageMode(ValidationMessageMode.Always)
                                .ValidationMessagePosition(Position.Bottom)
                                .SearchEnabled(config.SeachEnabled)
                );
        }

        public static void AddCustomFormTagBox<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression, TagControlConfig config)
        {
            factory.AddSimpleFor(expression)
                .Editor(e => e.TagBox()
                                .ValueExpr(config.KeyField)
                                .DataSource(d => d.Mvc()
                                                .Controller(config.DbSourceController)
                                                .LoadAction(config.DBSourceAction)
                                                .LoadMode(config.LoadMode)
                                                .Key(config.KeyField))
                                .Height(40)
                                .DisplayExpr(config.DisplayField)
                                .OnValueChanged(config.ValueChangeCallBack)
                                .ValidationMessageMode(ValidationMessageMode.Always)
                                .ValidationMessagePosition(Position.Bottom)
                                .SearchEnabled(config.SeachEnabled)
                                .ShowSelectionControls(true)
                                .MaxDisplayedTags(config.MaxDisplayTags)
                                .Disabled(config.Disabled)
                ).CssClass($"my-2 {config.CssClass}");
        }

        public static void AddCustomFormDateBox<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression)
        {
            factory.AddSimpleFor(expression)
                .Editor(e => e.DateBox()
                            .Height(40)
                            .ValidationMessageMode(ValidationMessageMode.Always)
                            .ValidationMessagePosition(Position.Bottom))
                            .CssClass("my-2");
        }

        public static void AddCustomFormTextArea<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression)
        {

            factory.AddSimpleFor(expression)
                .Editor(e => e.TextArea()
                                        .ValidationMessageMode(ValidationMessageMode.Always)
                                        .ValidationMessagePosition(Position.Bottom)).CssClass("my-2");
        }

        public static void AddCustomFormSwitch<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression, string cssClass = "", bool disabled = false)
        {
            factory.AddSimpleFor(expression)
                    .Editor(e => e.Switch()
                                    .Disabled(disabled)
                                    .ValidationMessageMode(ValidationMessageMode.Always)
                                    .ValidationMessagePosition(Position.Bottom)).CssClass(cssClass);
        }

        public static void AddCustomFormCheckbox<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression, string cssClass = "", bool disabled = false)
        {
            factory.AddSimpleFor(expression)
                    .Editor(e => e.CheckBox()
                                    .Disabled(disabled)
                                    .ValidationMessageMode(ValidationMessageMode.Always)
                                    .ValidationMessagePosition(Position.Bottom)).CssClass($"my-2 {cssClass}");
        }

    }
}
