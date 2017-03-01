#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.GiangVienCamKetKhongTruThueProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienCamKetKhongTruThueDataSourceDesigner))]
	public class GiangVienCamKetKhongTruThueDataSource : ProviderDataSource<GiangVienCamKetKhongTruThue, GiangVienCamKetKhongTruThueKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueDataSource class.
		/// </summary>
		public GiangVienCamKetKhongTruThueDataSource() : base(new GiangVienCamKetKhongTruThueService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienCamKetKhongTruThueDataSourceView used by the GiangVienCamKetKhongTruThueDataSource.
		/// </summary>
		protected GiangVienCamKetKhongTruThueDataSourceView GiangVienCamKetKhongTruThueView
		{
			get { return ( View as GiangVienCamKetKhongTruThueDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienCamKetKhongTruThueDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienCamKetKhongTruThueSelectMethod SelectMethod
		{
			get
			{
				GiangVienCamKetKhongTruThueSelectMethod selectMethod = GiangVienCamKetKhongTruThueSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienCamKetKhongTruThueSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienCamKetKhongTruThueDataSourceView class that is to be
		/// used by the GiangVienCamKetKhongTruThueDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienCamKetKhongTruThueDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienCamKetKhongTruThue, GiangVienCamKetKhongTruThueKey> GetNewDataSourceView()
		{
			return new GiangVienCamKetKhongTruThueDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the GiangVienCamKetKhongTruThueDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienCamKetKhongTruThueDataSourceView : ProviderDataSourceView<GiangVienCamKetKhongTruThue, GiangVienCamKetKhongTruThueKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienCamKetKhongTruThueDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienCamKetKhongTruThueDataSourceView(GiangVienCamKetKhongTruThueDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienCamKetKhongTruThueDataSource GiangVienCamKetKhongTruThueOwner
		{
			get { return Owner as GiangVienCamKetKhongTruThueDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienCamKetKhongTruThueSelectMethod SelectMethod
		{
			get { return GiangVienCamKetKhongTruThueOwner.SelectMethod; }
			set { GiangVienCamKetKhongTruThueOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienCamKetKhongTruThueService GiangVienCamKetKhongTruThueProvider
		{
			get { return Provider as GiangVienCamKetKhongTruThueService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienCamKetKhongTruThue> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienCamKetKhongTruThue> results = null;
			GiangVienCamKetKhongTruThue item;
			count = 0;
			
			System.Int32 _maGiangVien;
			System.String _namHoc;
			System.String _hocKy;

			switch ( SelectMethod )
			{
				case GiangVienCamKetKhongTruThueSelectMethod.Get:
					GiangVienCamKetKhongTruThueKey entityKey  = new GiangVienCamKetKhongTruThueKey();
					entityKey.Load(values);
					item = GiangVienCamKetKhongTruThueProvider.Get(entityKey);
					results = new TList<GiangVienCamKetKhongTruThue>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienCamKetKhongTruThueSelectMethod.GetAll:
                    results = GiangVienCamKetKhongTruThueProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienCamKetKhongTruThueSelectMethod.GetPaged:
					results = GiangVienCamKetKhongTruThueProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienCamKetKhongTruThueSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienCamKetKhongTruThueProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienCamKetKhongTruThueProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienCamKetKhongTruThueSelectMethod.GetByMaGiangVienNamHocHocKy:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					_namHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
					_hocKy = ( values["HocKy"] != null ) ? (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String)) : string.Empty;
					item = GiangVienCamKetKhongTruThueProvider.GetByMaGiangVienNamHocHocKy(_maGiangVien, _namHoc, _hocKy);
					results = new TList<GiangVienCamKetKhongTruThue>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienCamKetKhongTruThueSelectMethod.GetByMaGiangVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					results = GiangVienCamKetKhongTruThueProvider.GetByMaGiangVien(_maGiangVien, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == GiangVienCamKetKhongTruThueSelectMethod.Get || SelectMethod == GiangVienCamKetKhongTruThueSelectMethod.GetByMaGiangVienNamHocHocKy )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				GiangVienCamKetKhongTruThue entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienCamKetKhongTruThueProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<GiangVienCamKetKhongTruThue> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienCamKetKhongTruThueProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienCamKetKhongTruThueDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienCamKetKhongTruThueDataSource class.
	/// </summary>
	public class GiangVienCamKetKhongTruThueDataSourceDesigner : ProviderDataSourceDesigner<GiangVienCamKetKhongTruThue, GiangVienCamKetKhongTruThueKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueDataSourceDesigner class.
		/// </summary>
		public GiangVienCamKetKhongTruThueDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienCamKetKhongTruThueSelectMethod SelectMethod
		{
			get { return ((GiangVienCamKetKhongTruThueDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new GiangVienCamKetKhongTruThueDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienCamKetKhongTruThueDataSourceActionList

	/// <summary>
	/// Supports the GiangVienCamKetKhongTruThueDataSourceDesigner class.
	/// </summary>
	internal class GiangVienCamKetKhongTruThueDataSourceActionList : DesignerActionList
	{
		private GiangVienCamKetKhongTruThueDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienCamKetKhongTruThueDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienCamKetKhongTruThueDataSourceActionList(GiangVienCamKetKhongTruThueDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienCamKetKhongTruThueSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion GiangVienCamKetKhongTruThueDataSourceActionList
	
	#endregion GiangVienCamKetKhongTruThueDataSourceDesigner
	
	#region GiangVienCamKetKhongTruThueSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienCamKetKhongTruThueDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienCamKetKhongTruThueSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaGiangVienNamHocHocKy method.
		/// </summary>
		GetByMaGiangVienNamHocHocKy,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien
	}
	
	#endregion GiangVienCamKetKhongTruThueSelectMethod

	#region GiangVienCamKetKhongTruThueFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienCamKetKhongTruThue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienCamKetKhongTruThueFilter : SqlFilter<GiangVienCamKetKhongTruThueColumn>
	{
	}
	
	#endregion GiangVienCamKetKhongTruThueFilter

	#region GiangVienCamKetKhongTruThueExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienCamKetKhongTruThue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienCamKetKhongTruThueExpressionBuilder : SqlExpressionBuilder<GiangVienCamKetKhongTruThueColumn>
	{
	}
	
	#endregion GiangVienCamKetKhongTruThueExpressionBuilder	

	#region GiangVienCamKetKhongTruThueProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienCamKetKhongTruThueChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienCamKetKhongTruThue"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienCamKetKhongTruThueProperty : ChildEntityProperty<GiangVienCamKetKhongTruThueChildEntityTypes>
	{
	}
	
	#endregion GiangVienCamKetKhongTruThueProperty
}

