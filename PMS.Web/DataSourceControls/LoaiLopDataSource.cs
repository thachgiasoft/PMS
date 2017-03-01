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
	/// Represents the DataRepository.LoaiLopProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LoaiLopDataSourceDesigner))]
	public class LoaiLopDataSource : ProviderDataSource<LoaiLop, LoaiLopKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiLopDataSource class.
		/// </summary>
		public LoaiLopDataSource() : base(new LoaiLopService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LoaiLopDataSourceView used by the LoaiLopDataSource.
		/// </summary>
		protected LoaiLopDataSourceView LoaiLopView
		{
			get { return ( View as LoaiLopDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LoaiLopDataSource control invokes to retrieve data.
		/// </summary>
		public LoaiLopSelectMethod SelectMethod
		{
			get
			{
				LoaiLopSelectMethod selectMethod = LoaiLopSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LoaiLopSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LoaiLopDataSourceView class that is to be
		/// used by the LoaiLopDataSource.
		/// </summary>
		/// <returns>An instance of the LoaiLopDataSourceView class.</returns>
		protected override BaseDataSourceView<LoaiLop, LoaiLopKey> GetNewDataSourceView()
		{
			return new LoaiLopDataSourceView(this, DefaultViewName);
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
	/// Supports the LoaiLopDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LoaiLopDataSourceView : ProviderDataSourceView<LoaiLop, LoaiLopKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LoaiLopDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LoaiLopDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LoaiLopDataSourceView(LoaiLopDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LoaiLopDataSource LoaiLopOwner
		{
			get { return Owner as LoaiLopDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LoaiLopSelectMethod SelectMethod
		{
			get { return LoaiLopOwner.SelectMethod; }
			set { LoaiLopOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LoaiLopService LoaiLopProvider
		{
			get { return Provider as LoaiLopService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LoaiLop> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LoaiLop> results = null;
			LoaiLop item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case LoaiLopSelectMethod.Get:
					LoaiLopKey entityKey  = new LoaiLopKey();
					entityKey.Load(values);
					item = LoaiLopProvider.Get(entityKey);
					results = new TList<LoaiLop>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LoaiLopSelectMethod.GetAll:
                    results = LoaiLopProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LoaiLopSelectMethod.GetPaged:
					results = LoaiLopProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LoaiLopSelectMethod.Find:
					if ( FilterParameters != null )
						results = LoaiLopProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LoaiLopProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LoaiLopSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = LoaiLopProvider.GetById(_id);
					results = new TList<LoaiLop>();
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
			if ( SelectMethod == LoaiLopSelectMethod.Get || SelectMethod == LoaiLopSelectMethod.GetById )
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
				LoaiLop entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LoaiLopProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LoaiLop> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LoaiLopProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LoaiLopDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LoaiLopDataSource class.
	/// </summary>
	public class LoaiLopDataSourceDesigner : ProviderDataSourceDesigner<LoaiLop, LoaiLopKey>
	{
		/// <summary>
		/// Initializes a new instance of the LoaiLopDataSourceDesigner class.
		/// </summary>
		public LoaiLopDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiLopSelectMethod SelectMethod
		{
			get { return ((LoaiLopDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LoaiLopDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LoaiLopDataSourceActionList

	/// <summary>
	/// Supports the LoaiLopDataSourceDesigner class.
	/// </summary>
	internal class LoaiLopDataSourceActionList : DesignerActionList
	{
		private LoaiLopDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LoaiLopDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LoaiLopDataSourceActionList(LoaiLopDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LoaiLopSelectMethod SelectMethod
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

	#endregion LoaiLopDataSourceActionList
	
	#endregion LoaiLopDataSourceDesigner
	
	#region LoaiLopSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LoaiLopDataSource.SelectMethod property.
	/// </summary>
	public enum LoaiLopSelectMethod
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
	
	#endregion LoaiLopSelectMethod

	#region LoaiLopFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiLopFilter : SqlFilter<LoaiLopColumn>
	{
	}
	
	#endregion LoaiLopFilter

	#region LoaiLopExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiLopExpressionBuilder : SqlExpressionBuilder<LoaiLopColumn>
	{
	}
	
	#endregion LoaiLopExpressionBuilder	

	#region LoaiLopProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LoaiLopChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LoaiLop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LoaiLopProperty : ChildEntityProperty<LoaiLopChildEntityTypes>
	{
	}
	
	#endregion LoaiLopProperty
}

