using System.Web;
using System.Web.Optimization;

namespace J.MainWeb
{
	public class BundleConfig
	{
		// 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles)
		{
			#region CSS
			#region bootstrap
			bundles.Add(new StyleBundle("~/Static/Resources/bootstrap/css").Include(
						"~/Static/Resources/bootstrap/bootstrap.css",
						"~/Static/Resources/bootstrap/bootstrap-theme.css"));
			#endregion

			#region uploadify CSS
			bundles.Add(new StyleBundle("~/Static/Resources/uploadify/css").Include(
						"~/Static/Resources/uploadify/uploadify.css"));
			#endregion

			#region site CSS
			bundles.Add(new StyleBundle("~/Static/Resources/site/css").Include(
						"~/Static/Resources/site/site.css"));
			#endregion
			#endregion

			#region JS
			#region html5shiv
			bundles.Add(new ScriptBundle("~/Static/Resources/html5shiv/js").Include(
						"~/Static/Resources/html5shiv/html5shiv.js"));
			#endregion

			#region respond
			bundles.Add(new ScriptBundle("~/Static/Resources/respond/js").Include(
						"~/Static/Resources/respond/respond.js"));
			#endregion

			#region jquery-1.x
			bundles.Add(new ScriptBundle("~/Static/Resources/jquery-1.x/js").Include(
						"~/Static/Resources/jquery-1.x/jquery-{version}.js"));
			#endregion

			#region jquery-2.x
			bundles.Add(new ScriptBundle("~/Static/Resources/jquery-2.x/js").Include(
						"~/Static/Resources/jquery-2.x/jquery-{version}.js"));
			#endregion

			#region Modernizr
			// 使用 Modernizr 的开发版本进行开发和了解信息。然后，当你做好
			// 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
			bundles.Add(new ScriptBundle("~/Static/Resources/modernizr/js").Include(
						"~/Static/Resources/modernizr/modernizr-*"));
			#endregion

			#region bootstrap
			bundles.Add(new ScriptBundle("~/Static/Resources/bootstrap/js").Include(
						"~/Static/Resources/bootstrap/bootstrap.js"));
			#endregion

			#region bootstrap-datepicker
			bundles.Add(new ScriptBundle("~/Static/Resources/bootstrap-datepicker/js").Include(
						"~/Static/Resources/bootstrap-datepicker/bootstrap-datepicker.js",
						"~/Static/Resources/bootstrap-datepicker/bootstrap-datepicker.zh-CN.js"));
			#endregion

			#region jquery validate
			bundles.Add(new ScriptBundle("~/Static/Resources/jquery.validate/js").Include(
						"~/Static/Resources/jquery.validate/jquery.validate.js",
						"~/Static/Resources/jquery.validate/additional-methods.js",
						"~/Static/Resources/jquery.validate/messages_zh.js"));
			#endregion

			#region mustache
			bundles.Add(new ScriptBundle("~/Static/Resources/mustache/js").Include(
						"~/Static/Resources/mustache/mustache.js"));
			#endregion

			#region json2
			bundles.Add(new ScriptBundle("~/Static/Resources/json2/js").Include(
						"~/Static/Resources/json2/json2.js"));
			#endregion

			#region uploadify
			bundles.Add(new ScriptBundle("~/Static/Resources/uploadify/js").Include(
						"~/Static/Resources/uploadify/jquery.uploadify.js"));
			#endregion

			#region jquery.base64
			bundles.Add(new ScriptBundle("~/Static/Resources/jquery.base64/js").Include(
						"~/Static/Resources/jquery.base64/jquery.base64.js"));
			#endregion

			#region extendjs
			bundles.Add(new ScriptBundle("~/Static/Resources/extendjs/js").Include(
						"~/Static/Resources/extendjs/extendjs.js"));
			#endregion
			#endregion
		}
	}
}