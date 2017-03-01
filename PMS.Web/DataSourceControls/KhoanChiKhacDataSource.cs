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
	/// Represents the DataRepository.KhoanChiKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoanChiKhacDataSourceDesigner))]
	public class KhoanChiKhacDataSource : ProviderDataSource<KhoanChiKhac, KhoanChiKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoanChiKhacDataSource class.
		/// </summary>
		public KhoanChiKhacDataSource() : base(new KhoanChiKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoanChiKhacDataSourceView used by the KhoanChiKhacDataSource.
		/// </summary>
		protected KhoanChiKhacDataSourceView KhoanChiKhacView
		{
			get { return ( View as KhoanChiKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoanChiKhacDataSource control invokes to retrieve data.
		/// </summary>
		public KhoanChiKhacSelectMethod SelectMethod
		{
			get
			{
				KhoanChiKhacSelectMethod selectMethod = KhoanChiKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoanChiKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoanChiKhacDataSourceView class that is to be
		/// used by the KhoanChiKhacDataSource.
		/// </summary>
		/// <returns>An instance of the KhoanChiKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoanChiKhac, KhoanChiKhacKey> GetNewDataSourceView()
		{
			return new KhoanChiKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoanChiKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoanChiKhacDataSourceView : ProviderDataSourceView<KhoanChiKhac, KhoanChiKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoanChiKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoanChiKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoanChiKhacDataSourceView(KhoanChiKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoanChiKhacDataSource KhoanChiKhacOwner
		{
			get { return Owner as KhoanChiKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoanChiKhacSelectMethod SelectMethod
		{
			get { return KhoanChiKhacOwner.SelectMethod; }
			set { KhoanChiKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoanChiKhacService KhoanChiKhacProvider
		{
			get { return Provider as KhoanChiKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoanChiKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoanChiKhac> results = null;
			KhoanChiKhac item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KhoanChiKhacSelectMethod.Get:
					KhoanChiKhacKey entityKey  = new KhoanChiKhacKey();
					entityKey.Load(values);
					item = KhoanChiKhacProvider.Get(entityKey);
					results = new TList<KhoanChiKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoanChiKhacSelectMethod.GetAll:
                    results = KhoanChiKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoanChiKhacSelectMethod.GetPaged:
					results = KhoanChiKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoanChiKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoanChiKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoanChiKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoanChiKhacSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KhoanChiKhacProvider.GetById(_id);
					results = new TList<KhoanChiKhac>();
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
			if ( SelectMethod == KhoanChiKhacSelectMethod.Get || SelectMethod == KhoanChiKhacSelectMethod.GetById )
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
				KhoanChiKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoanChiKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoanChiKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoanChiKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoanChiKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoanChiKhacDataSource class.
	/// </summary>
	public class KhoanChiKhacDataSourceDesigner : ProviderDataSourceDesigner<KhoanChiKhac, KhoanChiKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoanChiKhacDataSourceDesigner class.
		/// </summary>
		public KhoanChiKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoanChiKhacSelectMethod SelectMethod
		{
			get { return ((KhoanChiKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoanChiKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoanChiKhacDataSourceActionList

	/// <summary>
	/// Supports the KhoanChiKhacDataSourceDesigner class.
	/// </summary>
	internal class KhoanChiKhacDataSourceActionList : DesignerActionList
	{
		private KhoanChiKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoanChiKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoanChiKhacDataSourceActionList(KhoanChiKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoanChiKhacSelectMethod SelectMethod
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

	#endregion KhoanChiKhacDataSourceActionList
	
	#endregion KhoanChiKhacDataSourceDesigner
	
	#region KhoanChiKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoanChiKhacDataSource.SelectMethod property.
	/// </summary>
	public enum KhoanChiKhacSelectMethod
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
	
	#endregion KhoanChiKhacSelectMethod

	#region KhoanChiKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoanChiKhacFilter : SqlFilter<KhoanChiKhacColumn>
	{
	}
	
	#endregion KhoanChiKhacFilter

	#region KhoanChiKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoanChiKhacExpressionBuilder : SqlExpressionBuilder<KhoanChiKhacColumn>
	{
	}
	
	#endregion KhoanChiKhacExpressionBuilder	

	#region KhoanChiKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoanChiKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoanChiKhacProperty : ChildEntityProperty<KhoanChiKhacChildEntityTypes>
	{
	}
	
	#endregion KhoanChiKhacProperty
}

