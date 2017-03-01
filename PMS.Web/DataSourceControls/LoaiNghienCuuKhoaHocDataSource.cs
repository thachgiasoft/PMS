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
	/// Represents the DataRepository.LoaiNghienCuuKhoaHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LoaiNghienCuuKhoaHocDataSourceDesigner))]
	public class LoaiNghienCuuKhoaHocDataSource : ProviderDataSource<LoaiNghienCuuKhoaHoc, LoaiNghienCuuKhoaHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocDataSource class.
		/// </summary>
		public LoaiNghienCuuKhoaHocDataSource() : base(new LoaiNghienCuuKhoaHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LoaiNghienCuuKhoaHocDataSourceView used by the LoaiNghienCuuKhoaHocDataSource.
		/// </summary>
		protected LoaiNghienCuuKhoaHocDataSourceView LoaiNghienCuuKhoaHocView
		{
			get { return ( View as LoaiNghienCuuKhoaHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LoaiNghienCuuKhoaHocDataSource control invokes to retrieve data.
		/// </summary>
		public LoaiNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get
			{
				LoaiNghienCuuKhoaHocSelectMethod selectMethod = LoaiNghienCuuKhoaHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LoaiNghienCuuKhoaHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LoaiNghienCuuKhoaHocDataSourceView class that is to be
		/// used by the LoaiNghienCuuKhoaHocDataSource.
		/// </summary>
		/// <returns>An instance of the LoaiNghienCuuKhoaHocDataSourceView class.</returns>
		protected override BaseDataSourceView<LoaiNghienCuuKhoaHoc, LoaiNghienCuuKhoaHocKey> GetNewDataSourceView()
		{
			return new LoaiNghienCuuKhoaHocDataSourceView(this, DefaultViewName);
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
	/// Supports the LoaiNghienCuuKhoaHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LoaiNghienCuuKhoaHocDataSourceView : ProviderDataSourceView<LoaiNghienCuuKhoaHoc, LoaiNghienCuuKhoaHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LoaiNghienCuuKhoaHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LoaiNghienCuuKhoaHocDataSourceView(LoaiNghienCuuKhoaHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LoaiNghienCuuKhoaHocDataSource LoaiNghienCuuKhoaHocOwner
		{
			get { return Owner as LoaiNghienCuuKhoaHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LoaiNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return LoaiNghienCuuKhoaHocOwner.SelectMethod; }
			set { LoaiNghienCuuKhoaHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LoaiNghienCuuKhoaHocService LoaiNghienCuuKhoaHocProvider
		{
			get { return Provider as LoaiNghienCuuKhoaHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LoaiNghienCuuKhoaHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LoaiNghienCuuKhoaHoc> results = null;
			LoaiNghienCuuKhoaHoc item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case LoaiNghienCuuKhoaHocSelectMethod.Get:
					LoaiNghienCuuKhoaHocKey entityKey  = new LoaiNghienCuuKhoaHocKey();
					entityKey.Load(values);
					item = LoaiNghienCuuKhoaHocProvider.Get(entityKey);
					results = new TList<LoaiNghienCuuKhoaHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LoaiNghienCuuKhoaHocSelectMethod.GetAll:
                    results = LoaiNghienCuuKhoaHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LoaiNghienCuuKhoaHocSelectMethod.GetPaged:
					results = LoaiNghienCuuKhoaHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LoaiNghienCuuKhoaHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = LoaiNghienCuuKhoaHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LoaiNghienCuuKhoaHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LoaiNghienCuuKhoaHocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = LoaiNghienCuuKhoaHocProvider.GetById(_id);
					results = new TList<LoaiNghienCuuKhoaHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
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
			if ( SelectMethod == LoaiNghienCuuKhoaHocSelectMethod.Get || SelectMethod == LoaiNghienCuuKhoaHocSelectMethod.GetById )
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
				LoaiNghienCuuKhoaHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LoaiNghienCuuKhoaHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LoaiNghienCuuKhoaHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LoaiNghienCuuKhoaHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LoaiNghienCuuKhoaHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LoaiNghienCuuKhoaHocDataSource class.
	/// </summary>
	public class LoaiNghienCuuKhoaHocDataSourceDesigner : ProviderDataSourceDesigner<LoaiNghienCuuKhoaHoc, LoaiNghienCuuKhoaHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocDataSourceDesigner class.
		/// </summary>
		public LoaiNghienCuuKhoaHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return ((LoaiNghienCuuKhoaHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LoaiNghienCuuKhoaHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LoaiNghienCuuKhoaHocDataSourceActionList

	/// <summary>
	/// Supports the LoaiNghienCuuKhoaHocDataSourceDesigner class.
	/// </summary>
	internal class LoaiNghienCuuKhoaHocDataSourceActionList : DesignerActionList
	{
		private LoaiNghienCuuKhoaHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LoaiNghienCuuKhoaHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LoaiNghienCuuKhoaHocDataSourceActionList(LoaiNghienCuuKhoaHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiNghienCuuKhoaHocSelectMethod SelectMethod
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

	#endregion LoaiNghienCuuKhoaHocDataSourceActionList
	
	#endregion LoaiNghienCuuKhoaHocDataSourceDesigner
	
	#region LoaiNghienCuuKhoaHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LoaiNghienCuuKhoaHocDataSource.SelectMethod property.
	/// </summary>
	public enum LoaiNghienCuuKhoaHocSelectMethod
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
		GetById
	}
	
	#endregion LoaiNghienCuuKhoaHocSelectMethod

	#region LoaiNghienCuuKhoaHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNghienCuuKhoaHocFilter : SqlFilter<LoaiNghienCuuKhoaHocColumn>
	{
	}
	
	#endregion LoaiNghienCuuKhoaHocFilter

	#region LoaiNghienCuuKhoaHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNghienCuuKhoaHocExpressionBuilder : SqlExpressionBuilder<LoaiNghienCuuKhoaHocColumn>
	{
	}
	
	#endregion LoaiNghienCuuKhoaHocExpressionBuilder	

	#region LoaiNghienCuuKhoaHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LoaiNghienCuuKhoaHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiNghienCuuKhoaHocProperty : ChildEntityProperty<LoaiNghienCuuKhoaHocChildEntityTypes>
	{
	}
	
	#endregion LoaiNghienCuuKhoaHocProperty
}

