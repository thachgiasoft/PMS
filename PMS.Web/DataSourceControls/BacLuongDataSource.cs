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
	/// Represents the DataRepository.BacLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(BacLuongDataSourceDesigner))]
	public class BacLuongDataSource : ProviderDataSource<BacLuong, BacLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BacLuongDataSource class.
		/// </summary>
		public BacLuongDataSource() : base(new BacLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the BacLuongDataSourceView used by the BacLuongDataSource.
		/// </summary>
		protected BacLuongDataSourceView BacLuongView
		{
			get { return ( View as BacLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the BacLuongDataSource control invokes to retrieve data.
		/// </summary>
		public BacLuongSelectMethod SelectMethod
		{
			get
			{
				BacLuongSelectMethod selectMethod = BacLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (BacLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the BacLuongDataSourceView class that is to be
		/// used by the BacLuongDataSource.
		/// </summary>
		/// <returns>An instance of the BacLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<BacLuong, BacLuongKey> GetNewDataSourceView()
		{
			return new BacLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the BacLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class BacLuongDataSourceView : ProviderDataSourceView<BacLuong, BacLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BacLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the BacLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public BacLuongDataSourceView(BacLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal BacLuongDataSource BacLuongOwner
		{
			get { return Owner as BacLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal BacLuongSelectMethod SelectMethod
		{
			get { return BacLuongOwner.SelectMethod; }
			set { BacLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal BacLuongService BacLuongProvider
		{
			get { return Provider as BacLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<BacLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<BacLuong> results = null;
			BacLuong item;
			count = 0;
			
			System.String _maBacLuong;

			switch ( SelectMethod )
			{
				case BacLuongSelectMethod.Get:
					BacLuongKey entityKey  = new BacLuongKey();
					entityKey.Load(values);
					item = BacLuongProvider.Get(entityKey);
					results = new TList<BacLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case BacLuongSelectMethod.GetAll:
                    results = BacLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case BacLuongSelectMethod.GetPaged:
					results = BacLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case BacLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = BacLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = BacLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case BacLuongSelectMethod.GetByMaBacLuong:
					_maBacLuong = ( values["MaBacLuong"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaBacLuong"], typeof(System.String)) : string.Empty;
					item = BacLuongProvider.GetByMaBacLuong(_maBacLuong);
					results = new TList<BacLuong>();
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
			if ( SelectMethod == BacLuongSelectMethod.Get || SelectMethod == BacLuongSelectMethod.GetByMaBacLuong )
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
				BacLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					BacLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<BacLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			BacLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region BacLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the BacLuongDataSource class.
	/// </summary>
	public class BacLuongDataSourceDesigner : ProviderDataSourceDesigner<BacLuong, BacLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the BacLuongDataSourceDesigner class.
		/// </summary>
		public BacLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public BacLuongSelectMethod SelectMethod
		{
			get { return ((BacLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new BacLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region BacLuongDataSourceActionList

	/// <summary>
	/// Supports the BacLuongDataSourceDesigner class.
	/// </summary>
	internal class BacLuongDataSourceActionList : DesignerActionList
	{
		private BacLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the BacLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public BacLuongDataSourceActionList(BacLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public BacLuongSelectMethod SelectMethod
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

	#endregion BacLuongDataSourceActionList
	
	#endregion BacLuongDataSourceDesigner
	
	#region BacLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the BacLuongDataSource.SelectMethod property.
	/// </summary>
	public enum BacLuongSelectMethod
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
		/// Represents the GetByMaBacLuong method.
		/// </summary>
		GetByMaBacLuong
	}
	
	#endregion BacLuongSelectMethod

	#region BacLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BacLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BacLuongFilter : SqlFilter<BacLuongColumn>
	{
	}
	
	#endregion BacLuongFilter

	#region BacLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BacLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BacLuongExpressionBuilder : SqlExpressionBuilder<BacLuongColumn>
	{
	}
	
	#endregion BacLuongExpressionBuilder	

	#region BacLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;BacLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="BacLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BacLuongProperty : ChildEntityProperty<BacLuongChildEntityTypes>
	{
	}
	
	#endregion BacLuongProperty
}

