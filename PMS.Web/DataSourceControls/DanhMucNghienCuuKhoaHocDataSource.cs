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
	/// Represents the DataRepository.DanhMucNghienCuuKhoaHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DanhMucNghienCuuKhoaHocDataSourceDesigner))]
	public class DanhMucNghienCuuKhoaHocDataSource : ProviderDataSource<DanhMucNghienCuuKhoaHoc, DanhMucNghienCuuKhoaHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocDataSource class.
		/// </summary>
		public DanhMucNghienCuuKhoaHocDataSource() : base(new DanhMucNghienCuuKhoaHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DanhMucNghienCuuKhoaHocDataSourceView used by the DanhMucNghienCuuKhoaHocDataSource.
		/// </summary>
		protected DanhMucNghienCuuKhoaHocDataSourceView DanhMucNghienCuuKhoaHocView
		{
			get { return ( View as DanhMucNghienCuuKhoaHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DanhMucNghienCuuKhoaHocDataSource control invokes to retrieve data.
		/// </summary>
		public DanhMucNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get
			{
				DanhMucNghienCuuKhoaHocSelectMethod selectMethod = DanhMucNghienCuuKhoaHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DanhMucNghienCuuKhoaHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DanhMucNghienCuuKhoaHocDataSourceView class that is to be
		/// used by the DanhMucNghienCuuKhoaHocDataSource.
		/// </summary>
		/// <returns>An instance of the DanhMucNghienCuuKhoaHocDataSourceView class.</returns>
		protected override BaseDataSourceView<DanhMucNghienCuuKhoaHoc, DanhMucNghienCuuKhoaHocKey> GetNewDataSourceView()
		{
			return new DanhMucNghienCuuKhoaHocDataSourceView(this, DefaultViewName);
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
	/// Supports the DanhMucNghienCuuKhoaHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DanhMucNghienCuuKhoaHocDataSourceView : ProviderDataSourceView<DanhMucNghienCuuKhoaHoc, DanhMucNghienCuuKhoaHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DanhMucNghienCuuKhoaHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DanhMucNghienCuuKhoaHocDataSourceView(DanhMucNghienCuuKhoaHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DanhMucNghienCuuKhoaHocDataSource DanhMucNghienCuuKhoaHocOwner
		{
			get { return Owner as DanhMucNghienCuuKhoaHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DanhMucNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return DanhMucNghienCuuKhoaHocOwner.SelectMethod; }
			set { DanhMucNghienCuuKhoaHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DanhMucNghienCuuKhoaHocService DanhMucNghienCuuKhoaHocProvider
		{
			get { return Provider as DanhMucNghienCuuKhoaHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DanhMucNghienCuuKhoaHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DanhMucNghienCuuKhoaHoc> results = null;
			DanhMucNghienCuuKhoaHoc item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maLoaiNckh_nullable;

			switch ( SelectMethod )
			{
				case DanhMucNghienCuuKhoaHocSelectMethod.Get:
					DanhMucNghienCuuKhoaHocKey entityKey  = new DanhMucNghienCuuKhoaHocKey();
					entityKey.Load(values);
					item = DanhMucNghienCuuKhoaHocProvider.Get(entityKey);
					results = new TList<DanhMucNghienCuuKhoaHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DanhMucNghienCuuKhoaHocSelectMethod.GetAll:
                    results = DanhMucNghienCuuKhoaHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DanhMucNghienCuuKhoaHocSelectMethod.GetPaged:
					results = DanhMucNghienCuuKhoaHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DanhMucNghienCuuKhoaHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = DanhMucNghienCuuKhoaHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DanhMucNghienCuuKhoaHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DanhMucNghienCuuKhoaHocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DanhMucNghienCuuKhoaHocProvider.GetById(_id);
					results = new TList<DanhMucNghienCuuKhoaHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case DanhMucNghienCuuKhoaHocSelectMethod.GetByMaLoaiNckh:
					_maLoaiNckh_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaLoaiNckh"], typeof(System.Int32?));
					results = DanhMucNghienCuuKhoaHocProvider.GetByMaLoaiNckh(_maLoaiNckh_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == DanhMucNghienCuuKhoaHocSelectMethod.Get || SelectMethod == DanhMucNghienCuuKhoaHocSelectMethod.GetById )
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
				DanhMucNghienCuuKhoaHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DanhMucNghienCuuKhoaHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DanhMucNghienCuuKhoaHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DanhMucNghienCuuKhoaHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DanhMucNghienCuuKhoaHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DanhMucNghienCuuKhoaHocDataSource class.
	/// </summary>
	public class DanhMucNghienCuuKhoaHocDataSourceDesigner : ProviderDataSourceDesigner<DanhMucNghienCuuKhoaHoc, DanhMucNghienCuuKhoaHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocDataSourceDesigner class.
		/// </summary>
		public DanhMucNghienCuuKhoaHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhMucNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return ((DanhMucNghienCuuKhoaHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DanhMucNghienCuuKhoaHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DanhMucNghienCuuKhoaHocDataSourceActionList

	/// <summary>
	/// Supports the DanhMucNghienCuuKhoaHocDataSourceDesigner class.
	/// </summary>
	internal class DanhMucNghienCuuKhoaHocDataSourceActionList : DesignerActionList
	{
		private DanhMucNghienCuuKhoaHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DanhMucNghienCuuKhoaHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DanhMucNghienCuuKhoaHocDataSourceActionList(DanhMucNghienCuuKhoaHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhMucNghienCuuKhoaHocSelectMethod SelectMethod
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

	#endregion DanhMucNghienCuuKhoaHocDataSourceActionList
	
	#endregion DanhMucNghienCuuKhoaHocDataSourceDesigner
	
	#region DanhMucNghienCuuKhoaHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DanhMucNghienCuuKhoaHocDataSource.SelectMethod property.
	/// </summary>
	public enum DanhMucNghienCuuKhoaHocSelectMethod
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
		/// Represents the GetByMaLoaiNckh method.
		/// </summary>
		GetByMaLoaiNckh
	}
	
	#endregion DanhMucNghienCuuKhoaHocSelectMethod

	#region DanhMucNghienCuuKhoaHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucNghienCuuKhoaHocFilter : SqlFilter<DanhMucNghienCuuKhoaHocColumn>
	{
	}
	
	#endregion DanhMucNghienCuuKhoaHocFilter

	#region DanhMucNghienCuuKhoaHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucNghienCuuKhoaHocExpressionBuilder : SqlExpressionBuilder<DanhMucNghienCuuKhoaHocColumn>
	{
	}
	
	#endregion DanhMucNghienCuuKhoaHocExpressionBuilder	

	#region DanhMucNghienCuuKhoaHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DanhMucNghienCuuKhoaHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucNghienCuuKhoaHocProperty : ChildEntityProperty<DanhMucNghienCuuKhoaHocChildEntityTypes>
	{
	}
	
	#endregion DanhMucNghienCuuKhoaHocProperty
}

