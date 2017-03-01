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
	/// Represents the DataRepository.NoiDungDanhGiaProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NoiDungDanhGiaDataSourceDesigner))]
	public class NoiDungDanhGiaDataSource : ProviderDataSource<NoiDungDanhGia, NoiDungDanhGiaKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NoiDungDanhGiaDataSource class.
		/// </summary>
		public NoiDungDanhGiaDataSource() : base(new NoiDungDanhGiaService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NoiDungDanhGiaDataSourceView used by the NoiDungDanhGiaDataSource.
		/// </summary>
		protected NoiDungDanhGiaDataSourceView NoiDungDanhGiaView
		{
			get { return ( View as NoiDungDanhGiaDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NoiDungDanhGiaDataSource control invokes to retrieve data.
		/// </summary>
		public NoiDungDanhGiaSelectMethod SelectMethod
		{
			get
			{
				NoiDungDanhGiaSelectMethod selectMethod = NoiDungDanhGiaSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NoiDungDanhGiaSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NoiDungDanhGiaDataSourceView class that is to be
		/// used by the NoiDungDanhGiaDataSource.
		/// </summary>
		/// <returns>An instance of the NoiDungDanhGiaDataSourceView class.</returns>
		protected override BaseDataSourceView<NoiDungDanhGia, NoiDungDanhGiaKey> GetNewDataSourceView()
		{
			return new NoiDungDanhGiaDataSourceView(this, DefaultViewName);
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
	/// Supports the NoiDungDanhGiaDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NoiDungDanhGiaDataSourceView : ProviderDataSourceView<NoiDungDanhGia, NoiDungDanhGiaKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NoiDungDanhGiaDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NoiDungDanhGiaDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NoiDungDanhGiaDataSourceView(NoiDungDanhGiaDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NoiDungDanhGiaDataSource NoiDungDanhGiaOwner
		{
			get { return Owner as NoiDungDanhGiaDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NoiDungDanhGiaSelectMethod SelectMethod
		{
			get { return NoiDungDanhGiaOwner.SelectMethod; }
			set { NoiDungDanhGiaOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NoiDungDanhGiaService NoiDungDanhGiaProvider
		{
			get { return Provider as NoiDungDanhGiaService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NoiDungDanhGia> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NoiDungDanhGia> results = null;
			NoiDungDanhGia item;
			count = 0;
			
			System.String _maQuanLy;

			switch ( SelectMethod )
			{
				case NoiDungDanhGiaSelectMethod.Get:
					NoiDungDanhGiaKey entityKey  = new NoiDungDanhGiaKey();
					entityKey.Load(values);
					item = NoiDungDanhGiaProvider.Get(entityKey);
					results = new TList<NoiDungDanhGia>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NoiDungDanhGiaSelectMethod.GetAll:
                    results = NoiDungDanhGiaProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NoiDungDanhGiaSelectMethod.GetPaged:
					results = NoiDungDanhGiaProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NoiDungDanhGiaSelectMethod.Find:
					if ( FilterParameters != null )
						results = NoiDungDanhGiaProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NoiDungDanhGiaProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NoiDungDanhGiaSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					item = NoiDungDanhGiaProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<NoiDungDanhGia>();
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
			if ( SelectMethod == NoiDungDanhGiaSelectMethod.Get || SelectMethod == NoiDungDanhGiaSelectMethod.GetByMaQuanLy )
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
				NoiDungDanhGia entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NoiDungDanhGiaProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<NoiDungDanhGia> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NoiDungDanhGiaProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NoiDungDanhGiaDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NoiDungDanhGiaDataSource class.
	/// </summary>
	public class NoiDungDanhGiaDataSourceDesigner : ProviderDataSourceDesigner<NoiDungDanhGia, NoiDungDanhGiaKey>
	{
		/// <summary>
		/// Initializes a new instance of the NoiDungDanhGiaDataSourceDesigner class.
		/// </summary>
		public NoiDungDanhGiaDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NoiDungDanhGiaSelectMethod SelectMethod
		{
			get { return ((NoiDungDanhGiaDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NoiDungDanhGiaDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NoiDungDanhGiaDataSourceActionList

	/// <summary>
	/// Supports the NoiDungDanhGiaDataSourceDesigner class.
	/// </summary>
	internal class NoiDungDanhGiaDataSourceActionList : DesignerActionList
	{
		private NoiDungDanhGiaDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NoiDungDanhGiaDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NoiDungDanhGiaDataSourceActionList(NoiDungDanhGiaDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NoiDungDanhGiaSelectMethod SelectMethod
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

	#endregion NoiDungDanhGiaDataSourceActionList
	
	#endregion NoiDungDanhGiaDataSourceDesigner
	
	#region NoiDungDanhGiaSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NoiDungDanhGiaDataSource.SelectMethod property.
	/// </summary>
	public enum NoiDungDanhGiaSelectMethod
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
		GetByMaQuanLy
	}
	
	#endregion NoiDungDanhGiaSelectMethod

	#region NoiDungDanhGiaFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungDanhGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NoiDungDanhGiaFilter : SqlFilter<NoiDungDanhGiaColumn>
	{
	}
	
	#endregion NoiDungDanhGiaFilter

	#region NoiDungDanhGiaExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungDanhGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NoiDungDanhGiaExpressionBuilder : SqlExpressionBuilder<NoiDungDanhGiaColumn>
	{
	}
	
	#endregion NoiDungDanhGiaExpressionBuilder	

	#region NoiDungDanhGiaProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NoiDungDanhGiaChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NoiDungDanhGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NoiDungDanhGiaProperty : ChildEntityProperty<NoiDungDanhGiaChildEntityTypes>
	{
	}
	
	#endregion NoiDungDanhGiaProperty
}

