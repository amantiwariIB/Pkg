namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEntityEventListnerSchema

	/// <exclude/>
	public class UsrRealtyEntityEventListnerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEntityEventListnerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEntityEventListnerSchema(UsrRealtyEntityEventListnerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0974c41e-c387-4582-8705-5d830abbd38a");
			Name = "UsrRealtyEntityEventListner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4f5312d4-0035-4dc3-8637-9f2ec22f5c0f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,78,195,48,16,60,147,175,88,69,28,18,9,69,229,74,161,18,45,5,85,66,128,250,224,130,56,184,206,54,24,57,118,100,59,45,5,245,223,89,59,45,180,161,7,230,20,173,103,103,103,54,171,88,137,182,98,28,97,138,198,48,171,23,46,27,104,181,16,69,109,152,19,90,69,95,17,16,106,43,84,1,147,181,117,88,118,247,42,251,93,6,179,161,114,194,9,180,255,160,100,195,37,42,183,101,190,132,234,58,148,238,5,13,81,104,146,9,127,195,146,61,144,67,184,130,120,102,205,88,48,233,214,113,250,26,122,170,122,46,5,7,46,153,181,48,70,255,116,68,5,46,160,207,44,30,121,9,34,77,186,61,57,189,36,187,34,71,88,106,145,195,163,26,41,139,198,81,142,68,207,223,145,59,176,168,114,52,103,208,40,246,113,65,161,130,238,181,41,44,96,250,35,248,43,237,49,39,19,217,190,220,78,7,211,238,1,177,209,5,19,2,81,240,164,41,164,13,255,144,155,35,23,37,147,80,25,193,253,146,154,166,236,14,221,116,93,97,62,208,178,46,213,51,147,53,94,110,169,189,196,47,242,201,243,103,147,155,184,53,91,44,32,105,180,122,112,222,217,33,109,69,241,192,108,100,7,76,113,148,152,211,96,103,106,236,254,33,89,103,252,1,208,133,89,86,224,20,203,74,50,71,62,163,19,143,173,217,25,45,132,46,78,209,110,233,220,188,247,123,205,153,20,159,108,46,113,18,20,130,231,163,127,152,126,99,124,6,113,136,56,178,83,173,251,162,240,161,194,128,195,241,228,178,41,100,183,218,148,204,37,45,91,36,115,158,117,250,167,237,157,120,184,55,163,87,160,112,5,195,15,142,149,55,186,107,111,177,55,209,225,215,38,218,124,3,216,31,202,166,99,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("48490e9e-dea1-eec1-f22f-3bd438ae146c"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("4f5312d4-0035-4dc3-8637-9f2ec22f5c0f"),
				CreatedInSchemaUId = new Guid("0974c41e-c387-4582-8705-5d830abbd38a"),
				ModifiedInSchemaUId = new Guid("0974c41e-c387-4582-8705-5d830abbd38a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0974c41e-c387-4582-8705-5d830abbd38a"));
		}

		#endregion

	}

	#endregion

}

