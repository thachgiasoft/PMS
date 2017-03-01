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
	/// Represents the DataRepository.KyThiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KyThiDataSourceDesigner))]
	public class KyThiDataSource : ProviderDataSource<KyThi, KyThiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyThiDataSource class.
		/// </summary>
		public KyThiDataSource() : base(new KyThiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KyThiDataSourceView used by the KyThiDataSource.
		/// </summary>
		protected KyThiDataSourceView KyThiView
		{
			get { return ( View as KyThiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KyThiDataSource control invokes to retrieve data.
		/// </summary>
		public KyThiSelectMethod SelectMethod
		{
			get
			{
				KyThiSelectMethod selectMethod = KyThiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KyThiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KyThiDataSourceView class that is to be
		/// used by the KyThiDataSource.
		/// </summary>
		/// <returns>An instance of the KyThiDataSourceView class.</returns>
		protected override BaseDataSourceView<KyThi, KyThiKey> GetNewDataSourceView()
		{
			return new KyThiDataSourceView(this, DefaultViewName);
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
	/// Supports the KyThiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KyThiDataSourceView : ProviderDataSourceView<KyThi, KyThiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyThiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KyThiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KyThiDataSourceView(KyThiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KyThiDataSource KyThiOwner
		{
			get { return Owner as KyThiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KyThiSelectMethod SelectMethod
		{
			get { return KyThiOwner.SelectMethod; }
			set { KyThiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KyThiService KyThiProvider
		{
			get { return Provider as KyThiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KyThi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KyThi> results = null;
			KyThi item;
			count = 0;
			
			System.String _maKyThi;

			switch ( SelectMethod )
			{
				case KyThiSelectMethod.Get:
					KyThiKey entityKey  = new KyThiKey();
					entityKey.Load(values);
					item = KyThiProvider.Get(entityKey);
					results = new TList<KyThi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KyThiSelectMethod.GetAll:
                    results = KyThiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KyThiSelectMethod.GetPaged:
					results = KyThiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KyThiSelectMethod.Find:
					if ( FilterParameters != null )
						results = KyThiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KyThiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KyThiSelectMethod.GetByMaKyThi:
					_maKyThi = ( values["MaKyThi"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaKyThi"], typeof(System.String)) : string.Empty;
					item = KyThiProvider.GetByMaKyThi(_maKyThi);
					results = new TList<KyThi>();
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
			if ( SelectMethod == KyThiSelectMethod.Get || SelectMethod == KyThiSelectMethod.GetByMaKyThi )
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
				KyThi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KyThiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KyThi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KyThiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KyThiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KyThiDataSource class.
	/// </summary>
	public class KyThiDataSourceDesigner : ProviderDataSourceDesigner<KyThi, KyThiKey>
	{
		/// <summary>
		/// Initializes a new instance of the KyThiDataSourceDesigner class.
		/// </summary>
		public KyThiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KyThiSelectMethod SelectMethod
		{
			get { return ((KyThiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KyThiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KyThiDataSourceActionList

	/// <summary>
	/// Supports the KyThiDataSourceDesigner class.
	/// </summary>
	internal class KyThiDataSourceActionList : DesignerActionList
	{
		private KyThiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KyThiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KyThiDataSourceActionList(KyThiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KyThiSelectMethod SelectMethod
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

	#endregion KyThiDataSourceActionList
	
	#endregion KyThiDataSourceDesigner
	
	#region KyThiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KyThiDataSource.SelectMethod property.
	/// </summary>
	public enum KyThiSelectMethod
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
		/// Represents the GetByMaKyThi method.
		/// </summary>
		GetByMaKyThi
	}
	
	#endregion KyThiSelectMethod

	#region KyThiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyThiFilter : SqlFilter<KyThiColumn>
	{
	}
	
	#endregion KyThiFilter

	#region KyThiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyThiExpressionBuilder : SqlExpressionBuilder<KyThiColumn>
	{
	}
	
	#endregion KyThiExpressionBuilder	

	#region KyThiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KyThiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KyThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyThiProperty : ChildEntityProperty<KyThiChildEntityTypes>
	{
	}
	
	#endregion KyThiProperty
}

