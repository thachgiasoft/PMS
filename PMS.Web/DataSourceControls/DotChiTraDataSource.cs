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
	/// Represents the DataRepository.DotChiTraProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DotChiTraDataSourceDesigner))]
	public class DotChiTraDataSource : ProviderDataSource<DotChiTra, DotChiTraKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DotChiTraDataSource class.
		/// </summary>
		public DotChiTraDataSource() : base(new DotChiTraService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DotChiTraDataSourceView used by the DotChiTraDataSource.
		/// </summary>
		protected DotChiTraDataSourceView DotChiTraView
		{
			get { return ( View as DotChiTraDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DotChiTraDataSource control invokes to retrieve data.
		/// </summary>
		public DotChiTraSelectMethod SelectMethod
		{
			get
			{
				DotChiTraSelectMethod selectMethod = DotChiTraSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DotChiTraSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DotChiTraDataSourceView class that is to be
		/// used by the DotChiTraDataSource.
		/// </summary>
		/// <returns>An instance of the DotChiTraDataSourceView class.</returns>
		protected override BaseDataSourceView<DotChiTra, DotChiTraKey> GetNewDataSourceView()
		{
			return new DotChiTraDataSourceView(this, DefaultViewName);
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
	/// Supports the DotChiTraDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DotChiTraDataSourceView : ProviderDataSourceView<DotChiTra, DotChiTraKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DotChiTraDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DotChiTraDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DotChiTraDataSourceView(DotChiTraDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DotChiTraDataSource DotChiTraOwner
		{
			get { return Owner as DotChiTraDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DotChiTraSelectMethod SelectMethod
		{
			get { return DotChiTraOwner.SelectMethod; }
			set { DotChiTraOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DotChiTraService DotChiTraProvider
		{
			get { return Provider as DotChiTraService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DotChiTra> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DotChiTra> results = null;
			DotChiTra item;
			count = 0;
			
			System.Int32 _id;
			System.String sp90_NamHoc;
			System.String sp90_HocKy;

			switch ( SelectMethod )
			{
				case DotChiTraSelectMethod.Get:
					DotChiTraKey entityKey  = new DotChiTraKey();
					entityKey.Load(values);
					item = DotChiTraProvider.Get(entityKey);
					results = new TList<DotChiTra>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DotChiTraSelectMethod.GetAll:
                    results = DotChiTraProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DotChiTraSelectMethod.GetPaged:
					results = DotChiTraProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DotChiTraSelectMethod.Find:
					if ( FilterParameters != null )
						results = DotChiTraProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DotChiTraProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DotChiTraSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DotChiTraProvider.GetById(_id);
					results = new TList<DotChiTra>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case DotChiTraSelectMethod.GetByNamHocHocKy:
					sp90_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp90_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = DotChiTraProvider.GetByNamHocHocKy(sp90_NamHoc, sp90_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == DotChiTraSelectMethod.Get || SelectMethod == DotChiTraSelectMethod.GetById )
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
				DotChiTra entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DotChiTraProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DotChiTra> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DotChiTraProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DotChiTraDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DotChiTraDataSource class.
	/// </summary>
	public class DotChiTraDataSourceDesigner : ProviderDataSourceDesigner<DotChiTra, DotChiTraKey>
	{
		/// <summary>
		/// Initializes a new instance of the DotChiTraDataSourceDesigner class.
		/// </summary>
		public DotChiTraDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DotChiTraSelectMethod SelectMethod
		{
			get { return ((DotChiTraDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DotChiTraDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DotChiTraDataSourceActionList

	/// <summary>
	/// Supports the DotChiTraDataSourceDesigner class.
	/// </summary>
	internal class DotChiTraDataSourceActionList : DesignerActionList
	{
		private DotChiTraDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DotChiTraDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DotChiTraDataSourceActionList(DotChiTraDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DotChiTraSelectMethod SelectMethod
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

	#endregion DotChiTraDataSourceActionList
	
	#endregion DotChiTraDataSourceDesigner
	
	#region DotChiTraSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DotChiTraDataSource.SelectMethod property.
	/// </summary>
	public enum DotChiTraSelectMethod
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
	
	#endregion DotChiTraSelectMethod

	#region DotChiTraFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DotChiTra"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DotChiTraFilter : SqlFilter<DotChiTraColumn>
	{
	}
	
	#endregion DotChiTraFilter

	#region DotChiTraExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DotChiTra"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DotChiTraExpressionBuilder : SqlExpressionBuilder<DotChiTraColumn>
	{
	}
	
	#endregion DotChiTraExpressionBuilder	

	#region DotChiTraProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DotChiTraChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DotChiTra"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DotChiTraProperty : ChildEntityProperty<DotChiTraChildEntityTypes>
	{
	}
	
	#endregion DotChiTraProperty
}

