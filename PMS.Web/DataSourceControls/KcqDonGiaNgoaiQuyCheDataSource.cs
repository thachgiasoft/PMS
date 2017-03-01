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
	/// Represents the DataRepository.KcqDonGiaNgoaiQuyCheProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqDonGiaNgoaiQuyCheDataSourceDesigner))]
	public class KcqDonGiaNgoaiQuyCheDataSource : ProviderDataSource<KcqDonGiaNgoaiQuyChe, KcqDonGiaNgoaiQuyCheKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaNgoaiQuyCheDataSource class.
		/// </summary>
		public KcqDonGiaNgoaiQuyCheDataSource() : base(new KcqDonGiaNgoaiQuyCheService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqDonGiaNgoaiQuyCheDataSourceView used by the KcqDonGiaNgoaiQuyCheDataSource.
		/// </summary>
		protected KcqDonGiaNgoaiQuyCheDataSourceView KcqDonGiaNgoaiQuyCheView
		{
			get { return ( View as KcqDonGiaNgoaiQuyCheDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqDonGiaNgoaiQuyCheDataSource control invokes to retrieve data.
		/// </summary>
		public KcqDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get
			{
				KcqDonGiaNgoaiQuyCheSelectMethod selectMethod = KcqDonGiaNgoaiQuyCheSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqDonGiaNgoaiQuyCheSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqDonGiaNgoaiQuyCheDataSourceView class that is to be
		/// used by the KcqDonGiaNgoaiQuyCheDataSource.
		/// </summary>
		/// <returns>An instance of the KcqDonGiaNgoaiQuyCheDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqDonGiaNgoaiQuyChe, KcqDonGiaNgoaiQuyCheKey> GetNewDataSourceView()
		{
			return new KcqDonGiaNgoaiQuyCheDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqDonGiaNgoaiQuyCheDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqDonGiaNgoaiQuyCheDataSourceView : ProviderDataSourceView<KcqDonGiaNgoaiQuyChe, KcqDonGiaNgoaiQuyCheKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaNgoaiQuyCheDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqDonGiaNgoaiQuyCheDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqDonGiaNgoaiQuyCheDataSourceView(KcqDonGiaNgoaiQuyCheDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqDonGiaNgoaiQuyCheDataSource KcqDonGiaNgoaiQuyCheOwner
		{
			get { return Owner as KcqDonGiaNgoaiQuyCheDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get { return KcqDonGiaNgoaiQuyCheOwner.SelectMethod; }
			set { KcqDonGiaNgoaiQuyCheOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqDonGiaNgoaiQuyCheService KcqDonGiaNgoaiQuyCheProvider
		{
			get { return Provider as KcqDonGiaNgoaiQuyCheService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqDonGiaNgoaiQuyChe> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqDonGiaNgoaiQuyChe> results = null;
			KcqDonGiaNgoaiQuyChe item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqDonGiaNgoaiQuyCheSelectMethod.Get:
					KcqDonGiaNgoaiQuyCheKey entityKey  = new KcqDonGiaNgoaiQuyCheKey();
					entityKey.Load(values);
					item = KcqDonGiaNgoaiQuyCheProvider.Get(entityKey);
					results = new TList<KcqDonGiaNgoaiQuyChe>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqDonGiaNgoaiQuyCheSelectMethod.GetAll:
                    results = KcqDonGiaNgoaiQuyCheProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqDonGiaNgoaiQuyCheSelectMethod.GetPaged:
					results = KcqDonGiaNgoaiQuyCheProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqDonGiaNgoaiQuyCheSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqDonGiaNgoaiQuyCheProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqDonGiaNgoaiQuyCheProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqDonGiaNgoaiQuyCheSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqDonGiaNgoaiQuyCheProvider.GetById(_id);
					results = new TList<KcqDonGiaNgoaiQuyChe>();
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
			if ( SelectMethod == KcqDonGiaNgoaiQuyCheSelectMethod.Get || SelectMethod == KcqDonGiaNgoaiQuyCheSelectMethod.GetById )
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
				KcqDonGiaNgoaiQuyChe entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqDonGiaNgoaiQuyCheProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqDonGiaNgoaiQuyChe> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqDonGiaNgoaiQuyCheProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqDonGiaNgoaiQuyCheDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqDonGiaNgoaiQuyCheDataSource class.
	/// </summary>
	public class KcqDonGiaNgoaiQuyCheDataSourceDesigner : ProviderDataSourceDesigner<KcqDonGiaNgoaiQuyChe, KcqDonGiaNgoaiQuyCheKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqDonGiaNgoaiQuyCheDataSourceDesigner class.
		/// </summary>
		public KcqDonGiaNgoaiQuyCheDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqDonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get { return ((KcqDonGiaNgoaiQuyCheDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqDonGiaNgoaiQuyCheDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqDonGiaNgoaiQuyCheDataSourceActionList

	/// <summary>
	/// Supports the KcqDonGiaNgoaiQuyCheDataSourceDesigner class.
	/// </summary>
	internal class KcqDonGiaNgoaiQuyCheDataSourceActionList : DesignerActionList
	{
		private KcqDonGiaNgoaiQuyCheDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaNgoaiQuyCheDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqDonGiaNgoaiQuyCheDataSourceActionList(KcqDonGiaNgoaiQuyCheDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqDonGiaNgoaiQuyCheSelectMethod SelectMethod
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

	#endregion KcqDonGiaNgoaiQuyCheDataSourceActionList
	
	#endregion KcqDonGiaNgoaiQuyCheDataSourceDesigner
	
	#region KcqDonGiaNgoaiQuyCheSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqDonGiaNgoaiQuyCheDataSource.SelectMethod property.
	/// </summary>
	public enum KcqDonGiaNgoaiQuyCheSelectMethod
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
	
	#endregion KcqDonGiaNgoaiQuyCheSelectMethod

	#region KcqDonGiaNgoaiQuyCheFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqDonGiaNgoaiQuyCheFilter : SqlFilter<KcqDonGiaNgoaiQuyCheColumn>
	{
	}
	
	#endregion KcqDonGiaNgoaiQuyCheFilter

	#region KcqDonGiaNgoaiQuyCheExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqDonGiaNgoaiQuyCheExpressionBuilder : SqlExpressionBuilder<KcqDonGiaNgoaiQuyCheColumn>
	{
	}
	
	#endregion KcqDonGiaNgoaiQuyCheExpressionBuilder	

	#region KcqDonGiaNgoaiQuyCheProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqDonGiaNgoaiQuyCheChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqDonGiaNgoaiQuyCheProperty : ChildEntityProperty<KcqDonGiaNgoaiQuyCheChildEntityTypes>
	{
	}
	
	#endregion KcqDonGiaNgoaiQuyCheProperty
}

