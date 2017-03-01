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
	/// Represents the DataRepository.GiangVienLopHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienLopHocPhanDataSourceDesigner))]
	public class GiangVienLopHocPhanDataSource : ProviderDataSource<GiangVienLopHocPhan, GiangVienLopHocPhanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanDataSource class.
		/// </summary>
		public GiangVienLopHocPhanDataSource() : base(new GiangVienLopHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienLopHocPhanDataSourceView used by the GiangVienLopHocPhanDataSource.
		/// </summary>
		protected GiangVienLopHocPhanDataSourceView GiangVienLopHocPhanView
		{
			get { return ( View as GiangVienLopHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienLopHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienLopHocPhanSelectMethod SelectMethod
		{
			get
			{
				GiangVienLopHocPhanSelectMethod selectMethod = GiangVienLopHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienLopHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienLopHocPhanDataSourceView class that is to be
		/// used by the GiangVienLopHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienLopHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienLopHocPhan, GiangVienLopHocPhanKey> GetNewDataSourceView()
		{
			return new GiangVienLopHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienLopHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienLopHocPhanDataSourceView : ProviderDataSourceView<GiangVienLopHocPhan, GiangVienLopHocPhanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienLopHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienLopHocPhanDataSourceView(GiangVienLopHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienLopHocPhanDataSource GiangVienLopHocPhanOwner
		{
			get { return Owner as GiangVienLopHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienLopHocPhanSelectMethod SelectMethod
		{
			get { return GiangVienLopHocPhanOwner.SelectMethod; }
			set { GiangVienLopHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienLopHocPhanService GiangVienLopHocPhanProvider
		{
			get { return Provider as GiangVienLopHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienLopHocPhan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienLopHocPhan> results = null;
			GiangVienLopHocPhan item;
			count = 0;
			
			System.Int32 _maGiangVien;
			System.String _maLopHocPhan;
			System.Int32? _maHeSoNn_nullable;
			System.String sp2264_NamHoc;
			System.String sp2264_HocKy;

			switch ( SelectMethod )
			{
				case GiangVienLopHocPhanSelectMethod.Get:
					GiangVienLopHocPhanKey entityKey  = new GiangVienLopHocPhanKey();
					entityKey.Load(values);
					item = GiangVienLopHocPhanProvider.Get(entityKey);
					results = new TList<GiangVienLopHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienLopHocPhanSelectMethod.GetAll:
                    results = GiangVienLopHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienLopHocPhanSelectMethod.GetPaged:
					results = GiangVienLopHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienLopHocPhanSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienLopHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienLopHocPhanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienLopHocPhanSelectMethod.GetByMaGiangVienMaLopHocPhan:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					item = GiangVienLopHocPhanProvider.GetByMaGiangVienMaLopHocPhan(_maGiangVien, _maLopHocPhan);
					results = new TList<GiangVienLopHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case GiangVienLopHocPhanSelectMethod.GetByMaHeSoNn:
					_maHeSoNn_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHeSoNn"], typeof(System.Int32?));
					results = GiangVienLopHocPhanProvider.GetByMaHeSoNn(_maHeSoNn_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case GiangVienLopHocPhanSelectMethod.GetByNamHocHocKy:
					sp2264_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2264_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = GiangVienLopHocPhanProvider.GetByNamHocHocKy(sp2264_NamHoc, sp2264_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == GiangVienLopHocPhanSelectMethod.Get || SelectMethod == GiangVienLopHocPhanSelectMethod.GetByMaGiangVienMaLopHocPhan )
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
				GiangVienLopHocPhan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienLopHocPhanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienLopHocPhan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienLopHocPhanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienLopHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienLopHocPhanDataSource class.
	/// </summary>
	public class GiangVienLopHocPhanDataSourceDesigner : ProviderDataSourceDesigner<GiangVienLopHocPhan, GiangVienLopHocPhanKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanDataSourceDesigner class.
		/// </summary>
		public GiangVienLopHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienLopHocPhanSelectMethod SelectMethod
		{
			get { return ((GiangVienLopHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienLopHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienLopHocPhanDataSourceActionList

	/// <summary>
	/// Supports the GiangVienLopHocPhanDataSourceDesigner class.
	/// </summary>
	internal class GiangVienLopHocPhanDataSourceActionList : DesignerActionList
	{
		private GiangVienLopHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienLopHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienLopHocPhanDataSourceActionList(GiangVienLopHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienLopHocPhanSelectMethod SelectMethod
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

	#endregion GiangVienLopHocPhanDataSourceActionList
	
	#endregion GiangVienLopHocPhanDataSourceDesigner
	
	#region GiangVienLopHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienLopHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienLopHocPhanSelectMethod
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
		/// Represents the GetByMaGiangVienMaLopHocPhan method.
		/// </summary>
		GetByMaGiangVienMaLopHocPhan,
		/// <summary>
		/// Represents the GetByMaHeSoNn method.
		/// </summary>
		GetByMaHeSoNn,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion GiangVienLopHocPhanSelectMethod

	#region GiangVienLopHocPhanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienLopHocPhanFilter : SqlFilter<GiangVienLopHocPhanColumn>
	{
	}
	
	#endregion GiangVienLopHocPhanFilter

	#region GiangVienLopHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienLopHocPhanExpressionBuilder : SqlExpressionBuilder<GiangVienLopHocPhanColumn>
	{
	}
	
	#endregion GiangVienLopHocPhanExpressionBuilder	

	#region GiangVienLopHocPhanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienLopHocPhanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienLopHocPhanProperty : ChildEntityProperty<GiangVienLopHocPhanChildEntityTypes>
	{
	}
	
	#endregion GiangVienLopHocPhanProperty
}

