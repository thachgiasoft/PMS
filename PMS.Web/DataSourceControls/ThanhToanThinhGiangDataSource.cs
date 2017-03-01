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
	/// Represents the DataRepository.ThanhToanThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThanhToanThinhGiangDataSourceDesigner))]
	public class ThanhToanThinhGiangDataSource : ProviderDataSource<ThanhToanThinhGiang, ThanhToanThinhGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangDataSource class.
		/// </summary>
		public ThanhToanThinhGiangDataSource() : base(new ThanhToanThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThanhToanThinhGiangDataSourceView used by the ThanhToanThinhGiangDataSource.
		/// </summary>
		protected ThanhToanThinhGiangDataSourceView ThanhToanThinhGiangView
		{
			get { return ( View as ThanhToanThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThanhToanThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public ThanhToanThinhGiangSelectMethod SelectMethod
		{
			get
			{
				ThanhToanThinhGiangSelectMethod selectMethod = ThanhToanThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThanhToanThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThanhToanThinhGiangDataSourceView class that is to be
		/// used by the ThanhToanThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the ThanhToanThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<ThanhToanThinhGiang, ThanhToanThinhGiangKey> GetNewDataSourceView()
		{
			return new ThanhToanThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the ThanhToanThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThanhToanThinhGiangDataSourceView : ProviderDataSourceView<ThanhToanThinhGiang, ThanhToanThinhGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThanhToanThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThanhToanThinhGiangDataSourceView(ThanhToanThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThanhToanThinhGiangDataSource ThanhToanThinhGiangOwner
		{
			get { return Owner as ThanhToanThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThanhToanThinhGiangSelectMethod SelectMethod
		{
			get { return ThanhToanThinhGiangOwner.SelectMethod; }
			set { ThanhToanThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThanhToanThinhGiangService ThanhToanThinhGiangProvider
		{
			get { return Provider as ThanhToanThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThanhToanThinhGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThanhToanThinhGiang> results = null;
			ThanhToanThinhGiang item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ThanhToanThinhGiangSelectMethod.Get:
					ThanhToanThinhGiangKey entityKey  = new ThanhToanThinhGiangKey();
					entityKey.Load(values);
					item = ThanhToanThinhGiangProvider.Get(entityKey);
					results = new TList<ThanhToanThinhGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThanhToanThinhGiangSelectMethod.GetAll:
                    results = ThanhToanThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThanhToanThinhGiangSelectMethod.GetPaged:
					results = ThanhToanThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThanhToanThinhGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThanhToanThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThanhToanThinhGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThanhToanThinhGiangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThanhToanThinhGiangProvider.GetById(_id);
					results = new TList<ThanhToanThinhGiang>();
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
			if ( SelectMethod == ThanhToanThinhGiangSelectMethod.Get || SelectMethod == ThanhToanThinhGiangSelectMethod.GetById )
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
				ThanhToanThinhGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThanhToanThinhGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThanhToanThinhGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThanhToanThinhGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThanhToanThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThanhToanThinhGiangDataSource class.
	/// </summary>
	public class ThanhToanThinhGiangDataSourceDesigner : ProviderDataSourceDesigner<ThanhToanThinhGiang, ThanhToanThinhGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangDataSourceDesigner class.
		/// </summary>
		public ThanhToanThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhToanThinhGiangSelectMethod SelectMethod
		{
			get { return ((ThanhToanThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThanhToanThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThanhToanThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the ThanhToanThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class ThanhToanThinhGiangDataSourceActionList : DesignerActionList
	{
		private ThanhToanThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThanhToanThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThanhToanThinhGiangDataSourceActionList(ThanhToanThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhToanThinhGiangSelectMethod SelectMethod
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

	#endregion ThanhToanThinhGiangDataSourceActionList
	
	#endregion ThanhToanThinhGiangDataSourceDesigner
	
	#region ThanhToanThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThanhToanThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum ThanhToanThinhGiangSelectMethod
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
	
	#endregion ThanhToanThinhGiangSelectMethod

	#region ThanhToanThinhGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhToanThinhGiangFilter : SqlFilter<ThanhToanThinhGiangColumn>
	{
	}
	
	#endregion ThanhToanThinhGiangFilter

	#region ThanhToanThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhToanThinhGiangExpressionBuilder : SqlExpressionBuilder<ThanhToanThinhGiangColumn>
	{
	}
	
	#endregion ThanhToanThinhGiangExpressionBuilder	

	#region ThanhToanThinhGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThanhToanThinhGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhToanThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhToanThinhGiangProperty : ChildEntityProperty<ThanhToanThinhGiangChildEntityTypes>
	{
	}
	
	#endregion ThanhToanThinhGiangProperty
}

