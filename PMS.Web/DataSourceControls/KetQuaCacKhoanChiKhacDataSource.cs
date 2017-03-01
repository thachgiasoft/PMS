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
	/// Represents the DataRepository.KetQuaCacKhoanChiKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KetQuaCacKhoanChiKhacDataSourceDesigner))]
	public class KetQuaCacKhoanChiKhacDataSource : ProviderDataSource<KetQuaCacKhoanChiKhac, KetQuaCacKhoanChiKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacDataSource class.
		/// </summary>
		public KetQuaCacKhoanChiKhacDataSource() : base(new KetQuaCacKhoanChiKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KetQuaCacKhoanChiKhacDataSourceView used by the KetQuaCacKhoanChiKhacDataSource.
		/// </summary>
		protected KetQuaCacKhoanChiKhacDataSourceView KetQuaCacKhoanChiKhacView
		{
			get { return ( View as KetQuaCacKhoanChiKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KetQuaCacKhoanChiKhacDataSource control invokes to retrieve data.
		/// </summary>
		public KetQuaCacKhoanChiKhacSelectMethod SelectMethod
		{
			get
			{
				KetQuaCacKhoanChiKhacSelectMethod selectMethod = KetQuaCacKhoanChiKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KetQuaCacKhoanChiKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KetQuaCacKhoanChiKhacDataSourceView class that is to be
		/// used by the KetQuaCacKhoanChiKhacDataSource.
		/// </summary>
		/// <returns>An instance of the KetQuaCacKhoanChiKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<KetQuaCacKhoanChiKhac, KetQuaCacKhoanChiKhacKey> GetNewDataSourceView()
		{
			return new KetQuaCacKhoanChiKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the KetQuaCacKhoanChiKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KetQuaCacKhoanChiKhacDataSourceView : ProviderDataSourceView<KetQuaCacKhoanChiKhac, KetQuaCacKhoanChiKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KetQuaCacKhoanChiKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KetQuaCacKhoanChiKhacDataSourceView(KetQuaCacKhoanChiKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KetQuaCacKhoanChiKhacDataSource KetQuaCacKhoanChiKhacOwner
		{
			get { return Owner as KetQuaCacKhoanChiKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KetQuaCacKhoanChiKhacSelectMethod SelectMethod
		{
			get { return KetQuaCacKhoanChiKhacOwner.SelectMethod; }
			set { KetQuaCacKhoanChiKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KetQuaCacKhoanChiKhacService KetQuaCacKhoanChiKhacProvider
		{
			get { return Provider as KetQuaCacKhoanChiKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KetQuaCacKhoanChiKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KetQuaCacKhoanChiKhac> results = null;
			KetQuaCacKhoanChiKhac item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KetQuaCacKhoanChiKhacSelectMethod.Get:
					KetQuaCacKhoanChiKhacKey entityKey  = new KetQuaCacKhoanChiKhacKey();
					entityKey.Load(values);
					item = KetQuaCacKhoanChiKhacProvider.Get(entityKey);
					results = new TList<KetQuaCacKhoanChiKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KetQuaCacKhoanChiKhacSelectMethod.GetAll:
                    results = KetQuaCacKhoanChiKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KetQuaCacKhoanChiKhacSelectMethod.GetPaged:
					results = KetQuaCacKhoanChiKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KetQuaCacKhoanChiKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = KetQuaCacKhoanChiKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KetQuaCacKhoanChiKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KetQuaCacKhoanChiKhacSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KetQuaCacKhoanChiKhacProvider.GetById(_id);
					results = new TList<KetQuaCacKhoanChiKhac>();
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
			if ( SelectMethod == KetQuaCacKhoanChiKhacSelectMethod.Get || SelectMethod == KetQuaCacKhoanChiKhacSelectMethod.GetById )
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
				KetQuaCacKhoanChiKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KetQuaCacKhoanChiKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KetQuaCacKhoanChiKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KetQuaCacKhoanChiKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KetQuaCacKhoanChiKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KetQuaCacKhoanChiKhacDataSource class.
	/// </summary>
	public class KetQuaCacKhoanChiKhacDataSourceDesigner : ProviderDataSourceDesigner<KetQuaCacKhoanChiKhac, KetQuaCacKhoanChiKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacDataSourceDesigner class.
		/// </summary>
		public KetQuaCacKhoanChiKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaCacKhoanChiKhacSelectMethod SelectMethod
		{
			get { return ((KetQuaCacKhoanChiKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KetQuaCacKhoanChiKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KetQuaCacKhoanChiKhacDataSourceActionList

	/// <summary>
	/// Supports the KetQuaCacKhoanChiKhacDataSourceDesigner class.
	/// </summary>
	internal class KetQuaCacKhoanChiKhacDataSourceActionList : DesignerActionList
	{
		private KetQuaCacKhoanChiKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KetQuaCacKhoanChiKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KetQuaCacKhoanChiKhacDataSourceActionList(KetQuaCacKhoanChiKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaCacKhoanChiKhacSelectMethod SelectMethod
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

	#endregion KetQuaCacKhoanChiKhacDataSourceActionList
	
	#endregion KetQuaCacKhoanChiKhacDataSourceDesigner
	
	#region KetQuaCacKhoanChiKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KetQuaCacKhoanChiKhacDataSource.SelectMethod property.
	/// </summary>
	public enum KetQuaCacKhoanChiKhacSelectMethod
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
	
	#endregion KetQuaCacKhoanChiKhacSelectMethod

	#region KetQuaCacKhoanChiKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaCacKhoanChiKhacFilter : SqlFilter<KetQuaCacKhoanChiKhacColumn>
	{
	}
	
	#endregion KetQuaCacKhoanChiKhacFilter

	#region KetQuaCacKhoanChiKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaCacKhoanChiKhacExpressionBuilder : SqlExpressionBuilder<KetQuaCacKhoanChiKhacColumn>
	{
	}
	
	#endregion KetQuaCacKhoanChiKhacExpressionBuilder	

	#region KetQuaCacKhoanChiKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KetQuaCacKhoanChiKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaCacKhoanChiKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaCacKhoanChiKhacProperty : ChildEntityProperty<KetQuaCacKhoanChiKhacChildEntityTypes>
	{
	}
	
	#endregion KetQuaCacKhoanChiKhacProperty
}

