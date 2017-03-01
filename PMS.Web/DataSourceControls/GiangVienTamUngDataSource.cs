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
	/// Represents the DataRepository.GiangVienTamUngProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienTamUngDataSourceDesigner))]
	public class GiangVienTamUngDataSource : ProviderDataSource<GiangVienTamUng, GiangVienTamUngKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngDataSource class.
		/// </summary>
		public GiangVienTamUngDataSource() : base(new GiangVienTamUngService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienTamUngDataSourceView used by the GiangVienTamUngDataSource.
		/// </summary>
		protected GiangVienTamUngDataSourceView GiangVienTamUngView
		{
			get { return ( View as GiangVienTamUngDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienTamUngDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienTamUngSelectMethod SelectMethod
		{
			get
			{
				GiangVienTamUngSelectMethod selectMethod = GiangVienTamUngSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienTamUngSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienTamUngDataSourceView class that is to be
		/// used by the GiangVienTamUngDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienTamUngDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienTamUng, GiangVienTamUngKey> GetNewDataSourceView()
		{
			return new GiangVienTamUngDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienTamUngDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienTamUngDataSourceView : ProviderDataSourceView<GiangVienTamUng, GiangVienTamUngKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienTamUngDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienTamUngDataSourceView(GiangVienTamUngDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienTamUngDataSource GiangVienTamUngOwner
		{
			get { return Owner as GiangVienTamUngDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienTamUngSelectMethod SelectMethod
		{
			get { return GiangVienTamUngOwner.SelectMethod; }
			set { GiangVienTamUngOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienTamUngService GiangVienTamUngProvider
		{
			get { return Provider as GiangVienTamUngService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienTamUng> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienTamUng> results = null;
			GiangVienTamUng item;
			count = 0;
			
			System.Int32 _maQuanLy;
			System.String sp223_MaQuanLyGiangVien;
			System.String sp223_NamHoc;
			System.String sp224_NamHoc;
			System.String sp224_HocKy;

			switch ( SelectMethod )
			{
				case GiangVienTamUngSelectMethod.Get:
					GiangVienTamUngKey entityKey  = new GiangVienTamUngKey();
					entityKey.Load(values);
					item = GiangVienTamUngProvider.Get(entityKey);
					results = new TList<GiangVienTamUng>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienTamUngSelectMethod.GetAll:
                    results = GiangVienTamUngProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienTamUngSelectMethod.GetPaged:
					results = GiangVienTamUngProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienTamUngSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienTamUngProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienTamUngProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienTamUngSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = GiangVienTamUngProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<GiangVienTamUng>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case GiangVienTamUngSelectMethod.GetByMaQuanLyGiangVienNamHoc:
					sp223_MaQuanLyGiangVien = (System.String) EntityUtil.ChangeType(values["MaQuanLyGiangVien"], typeof(System.String));
					sp223_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = GiangVienTamUngProvider.GetByMaQuanLyGiangVienNamHoc(sp223_MaQuanLyGiangVien, sp223_NamHoc, StartIndex, PageSize);
					break;
				case GiangVienTamUngSelectMethod.GetByNamHocHocKy:
					sp224_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp224_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = GiangVienTamUngProvider.GetByNamHocHocKy(sp224_NamHoc, sp224_HocKy, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == GiangVienTamUngSelectMethod.Get || SelectMethod == GiangVienTamUngSelectMethod.GetByMaQuanLy )
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
				GiangVienTamUng entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienTamUngProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienTamUng> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienTamUngProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienTamUngDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienTamUngDataSource class.
	/// </summary>
	public class GiangVienTamUngDataSourceDesigner : ProviderDataSourceDesigner<GiangVienTamUng, GiangVienTamUngKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngDataSourceDesigner class.
		/// </summary>
		public GiangVienTamUngDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienTamUngSelectMethod SelectMethod
		{
			get { return ((GiangVienTamUngDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienTamUngDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienTamUngDataSourceActionList

	/// <summary>
	/// Supports the GiangVienTamUngDataSourceDesigner class.
	/// </summary>
	internal class GiangVienTamUngDataSourceActionList : DesignerActionList
	{
		private GiangVienTamUngDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienTamUngDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienTamUngDataSourceActionList(GiangVienTamUngDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienTamUngSelectMethod SelectMethod
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

	#endregion GiangVienTamUngDataSourceActionList
	
	#endregion GiangVienTamUngDataSourceDesigner
	
	#region GiangVienTamUngSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienTamUngDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienTamUngSelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaQuanLyGiangVienNamHoc method.
		/// </summary>
		GetByMaQuanLyGiangVienNamHoc,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion GiangVienTamUngSelectMethod

	#region GiangVienTamUngFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngFilter : SqlFilter<GiangVienTamUngColumn>
	{
	}
	
	#endregion GiangVienTamUngFilter

	#region GiangVienTamUngExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngExpressionBuilder : SqlExpressionBuilder<GiangVienTamUngColumn>
	{
	}
	
	#endregion GiangVienTamUngExpressionBuilder	

	#region GiangVienTamUngProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienTamUngChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTamUngProperty : ChildEntityProperty<GiangVienTamUngChildEntityTypes>
	{
	}
	
	#endregion GiangVienTamUngProperty
}

