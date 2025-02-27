namespace Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific
{
	using FormsElement = Maui.Controls.Entry;

	/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Entry.xml" path="Type[@FullName='Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific.Entry']/Docs/*" />
	public static class Entry
	{
		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Entry.xml" path="//Member[@MemberName='FontWeightProperty']/Docs/*" />
		public static readonly BindableProperty FontWeightProperty = BindableProperty.Create("FontWeight", typeof(string), typeof(FormsElement), FontWeight.None);

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Entry.xml" path="//Member[@MemberName='GetFontWeight'][1]/Docs/*" />
		public static string GetFontWeight(BindableObject element)
		{
			return (string)element.GetValue(FontWeightProperty);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Entry.xml" path="//Member[@MemberName='SetFontWeight'][1]/Docs/*" />
		public static void SetFontWeight(BindableObject element, string weight)
		{
			element.SetValue(FontWeightProperty, weight);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Entry.xml" path="//Member[@MemberName='GetFontWeight'][2]/Docs/*" />
		public static string GetFontWeight(this IPlatformElementConfiguration<Tizen, FormsElement> config)
		{
			return GetFontWeight(config.Element);
		}

		/// <include file="../../../../docs/Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific/Entry.xml" path="//Member[@MemberName='SetFontWeight'][2]/Docs/*" />
		public static IPlatformElementConfiguration<Tizen, FormsElement> SetFontWeight(this IPlatformElementConfiguration<Tizen, FormsElement> config, string weight)
		{
			SetFontWeight(config.Element, weight);
			return config;
		}
	}
}
