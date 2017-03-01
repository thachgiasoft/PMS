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
	/// Represents the DataRepository.ThangHeProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThangHeDataSourceDesigner))]
	public class ThangHeDataSource : ProviderDataSource<ThangHe, ThangHeKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThangHeDataSource class.
		/// </summary>
		public ThangHeDataSource() : base(new ThangHeService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThangHeDataSourceView used by the ThangHeDataSource.
		/// </summary>
		protected ThangHeDataSourceView ThangHeView
		{
			get { return ( View as ThangHeDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThangHeDataSource control invokes to retrieve data.
		/// </summary>
		public ThangHeSelectMethod SelectMethod
		{
			get
			{
				ThangHeSelectMethod selectMethod = ThangHeSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThangHeSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThangHeDataSourceView class that is to be
		/// used by the ThangHeDataSource.
		/// </summary>
		/// <returns>An instance of the ThangHeDataSourceView class.</returns>
		protected override BaseDataSourceView<ThangHe, ThangHeKey> GetNewDataSourceView()
		{
			return new ThangHeDataSourceView(this, DefaultViewName);
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
	/// Supports the ThangHeDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThangHeDataSourceView : ProviderDataSourceView<ThangHe, ThangHeKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThangHeDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThangHeDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThangHeDataSourceView(ThangHeDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThangHeDataSource ThangHeOwner
		{
			get { return Owner as ThangHeDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThangHeSelectMethod SelectMethod
		{
			get { return ThangHeOwner.SelectMethod; }
			set { ThangHeOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThangHeService ThangHeProvider
		{
			get { return Provider as ThangHeService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThangHe> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThangHe> results = null;
			ThangHe item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ThangHeSelectMethod.Get:
					ThangHeKey entityKey  = new ThangHeKey();
					entityKey.Load(values);
					item = ThangHeProvider.Get(entityKey);
					results = new TList<ThangHe>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThangHeSelectMethod.GetAll:
                    results = ThangHeProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThangHeSelectMethod.GetPaged:
					results = ThangHeProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThangHeSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThangHeProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThangHeProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThangHeSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThangHeProvider.GetById(_id);
					results = new TList<ThangHe>();
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
			if ( SelectMethod == ThangHeSelectMethod.Get || SelectMethod == ThangHeSelectMethod.GetById )
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
				ThangHe entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThangHeProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThangHe> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThangHeProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThangHeDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThangHeDataSource class.
	/// </summary>
	public class ThangHeDataSourceDesigner : ProviderDataSourceDesigner<ThangHe, ThangHeKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThangHeDataSourceDesigner class.
		/// </summary>
		public ThangHeDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThangHeSelectMethod SelectMethod
		{
			get { return ((ThangHeDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThangHeDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThangHeDataSourceActionList

	/// <summary>
	/// Supports the ThangHeDataSourceDesigner class.
	/// </summary>
	internal class ThangHeDataSourceActionList : DesignerActionList
	{
		private ThangHeDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThangHeDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThangHeDataSourceActionList(ThangHeDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThangHeSelectMethod SelectMethod
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

	#endregion ThangHeDataSourceActionList
	
	#endregion ThangHeDataSourceDesigner
	
	#region ThangHeSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThangHeDataSource.SelectMethod property.
	/// </summary>
	public enum ThangHeSelectMethod
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
	
	#endregion ThangHeSelectMethod

	#region ThangHeFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThangHe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThangHeFilter : SqlFilter<ThangHeColumn>
	{
	}
	
	#endregion ThangHeFilter

	#region ThangHeExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThangHe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThangHeExpressionBuilder : SqlExpressionBuilder<ThangHeColumn>
	{
	}
	
	#endregion ThangHeExpressionBuilder	

	#region ThangHeProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThangHeChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThangHe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThangHeProperty : ChildEntityProperty<ThangHeChildEntityTypes>
	{
	}
	
	#endregion ThangHeProperty
}

