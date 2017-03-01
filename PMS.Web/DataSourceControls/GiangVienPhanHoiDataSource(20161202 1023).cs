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
	/// Represents the DataRepository.GiangVienPhanHoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienPhanHoiDataSourceDesigner))]
	public class GiangVienPhanHoiDataSource : ProviderDataSource<GiangVienPhanHoi, GiangVienPhanHoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiDataSource class.
		/// </summary>
		public GiangVienPhanHoiDataSource() : base(new GiangVienPhanHoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienPhanHoiDataSourceView used by the GiangVienPhanHoiDataSource.
		/// </summary>
		protected GiangVienPhanHoiDataSourceView GiangVienPhanHoiView
		{
			get { return ( View as GiangVienPhanHoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienPhanHoiDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienPhanHoiSelectMethod SelectMethod
		{
			get
			{
				GiangVienPhanHoiSelectMethod selectMethod = GiangVienPhanHoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienPhanHoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienPhanHoiDataSourceView class that is to be
		/// used by the GiangVienPhanHoiDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienPhanHoiDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienPhanHoi, GiangVienPhanHoiKey> GetNewDataSourceView()
		{
			return new GiangVienPhanHoiDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienPhanHoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienPhanHoiDataSourceView : ProviderDataSourceView<GiangVienPhanHoi, GiangVienPhanHoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienPhanHoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienPhanHoiDataSourceView(GiangVienPhanHoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienPhanHoiDataSource GiangVienPhanHoiOwner
		{
			get { return Owner as GiangVienPhanHoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienPhanHoiSelectMethod SelectMethod
		{
			get { return GiangVienPhanHoiOwner.SelectMethod; }
			set { GiangVienPhanHoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienPhanHoiService GiangVienPhanHoiProvider
		{
			get { return Provider as GiangVienPhanHoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienPhanHoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienPhanHoi> results = null;
			GiangVienPhanHoi item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2318_NamHoc;
			System.String sp2318_HocKy;

			switch ( SelectMethod )
			{
				case GiangVienPhanHoiSelectMethod.Get:
					GiangVienPhanHoiKey entityKey  = new GiangVienPhanHoiKey();
					entityKey.Load(values);
					item = GiangVienPhanHoiProvider.Get(entityKey);
					results = new TList<GiangVienPhanHoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienPhanHoiSelectMethod.GetAll:
                    results = GiangVienPhanHoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienPhanHoiSelectMethod.GetPaged:
					results = GiangVienPhanHoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienPhanHoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienPhanHoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienPhanHoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienPhanHoiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienPhanHoiProvider.GetById(_id);
					results = new TList<GiangVienPhanHoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case GiangVienPhanHoiSelectMethod.GetByNamHocHocKy:
					sp2318_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2318_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = GiangVienPhanHoiProvider.GetByNamHocHocKy(sp2318_NamHoc, sp2318_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == GiangVienPhanHoiSelectMethod.Get || SelectMethod == GiangVienPhanHoiSelectMethod.GetById )
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
				GiangVienPhanHoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienPhanHoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienPhanHoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienPhanHoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienPhanHoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienPhanHoiDataSource class.
	/// </summary>
	public class GiangVienPhanHoiDataSourceDesigner : ProviderDataSourceDesigner<GiangVienPhanHoi, GiangVienPhanHoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiDataSourceDesigner class.
		/// </summary>
		public GiangVienPhanHoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienPhanHoiSelectMethod SelectMethod
		{
			get { return ((GiangVienPhanHoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienPhanHoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienPhanHoiDataSourceActionList

	/// <summary>
	/// Supports the GiangVienPhanHoiDataSourceDesigner class.
	/// </summary>
	internal class GiangVienPhanHoiDataSourceActionList : DesignerActionList
	{
		private GiangVienPhanHoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienPhanHoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienPhanHoiDataSourceActionList(GiangVienPhanHoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienPhanHoiSelectMethod SelectMethod
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

	#endregion GiangVienPhanHoiDataSourceActionList
	
	#endregion GiangVienPhanHoiDataSourceDesigner
	
	#region GiangVienPhanHoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienPhanHoiDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienPhanHoiSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion GiangVienPhanHoiSelectMethod

	#region GiangVienPhanHoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienPhanHoiFilter : SqlFilter<GiangVienPhanHoiColumn>
	{
	}
	
	#endregion GiangVienPhanHoiFilter

	#region GiangVienPhanHoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienPhanHoiExpressionBuilder : SqlExpressionBuilder<GiangVienPhanHoiColumn>
	{
	}
	
	#endregion GiangVienPhanHoiExpressionBuilder	

	#region GiangVienPhanHoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienPhanHoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienPhanHoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienPhanHoiProperty : ChildEntityProperty<GiangVienPhanHoiChildEntityTypes>
	{
	}
	
	#endregion GiangVienPhanHoiProperty
}

