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
	/// Represents the DataRepository.KcqHeSoQuyDoiTinChiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqHeSoQuyDoiTinChiDataSourceDesigner))]
	public class KcqHeSoQuyDoiTinChiDataSource : ProviderDataSource<KcqHeSoQuyDoiTinChi, KcqHeSoQuyDoiTinChiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoQuyDoiTinChiDataSource class.
		/// </summary>
		public KcqHeSoQuyDoiTinChiDataSource() : base(new KcqHeSoQuyDoiTinChiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqHeSoQuyDoiTinChiDataSourceView used by the KcqHeSoQuyDoiTinChiDataSource.
		/// </summary>
		protected KcqHeSoQuyDoiTinChiDataSourceView KcqHeSoQuyDoiTinChiView
		{
			get { return ( View as KcqHeSoQuyDoiTinChiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqHeSoQuyDoiTinChiDataSource control invokes to retrieve data.
		/// </summary>
		public KcqHeSoQuyDoiTinChiSelectMethod SelectMethod
		{
			get
			{
				KcqHeSoQuyDoiTinChiSelectMethod selectMethod = KcqHeSoQuyDoiTinChiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqHeSoQuyDoiTinChiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqHeSoQuyDoiTinChiDataSourceView class that is to be
		/// used by the KcqHeSoQuyDoiTinChiDataSource.
		/// </summary>
		/// <returns>An instance of the KcqHeSoQuyDoiTinChiDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqHeSoQuyDoiTinChi, KcqHeSoQuyDoiTinChiKey> GetNewDataSourceView()
		{
			return new KcqHeSoQuyDoiTinChiDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqHeSoQuyDoiTinChiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqHeSoQuyDoiTinChiDataSourceView : ProviderDataSourceView<KcqHeSoQuyDoiTinChi, KcqHeSoQuyDoiTinChiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoQuyDoiTinChiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqHeSoQuyDoiTinChiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqHeSoQuyDoiTinChiDataSourceView(KcqHeSoQuyDoiTinChiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqHeSoQuyDoiTinChiDataSource KcqHeSoQuyDoiTinChiOwner
		{
			get { return Owner as KcqHeSoQuyDoiTinChiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqHeSoQuyDoiTinChiSelectMethod SelectMethod
		{
			get { return KcqHeSoQuyDoiTinChiOwner.SelectMethod; }
			set { KcqHeSoQuyDoiTinChiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqHeSoQuyDoiTinChiService KcqHeSoQuyDoiTinChiProvider
		{
			get { return Provider as KcqHeSoQuyDoiTinChiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqHeSoQuyDoiTinChi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqHeSoQuyDoiTinChi> results = null;
			KcqHeSoQuyDoiTinChi item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqHeSoQuyDoiTinChiSelectMethod.Get:
					KcqHeSoQuyDoiTinChiKey entityKey  = new KcqHeSoQuyDoiTinChiKey();
					entityKey.Load(values);
					item = KcqHeSoQuyDoiTinChiProvider.Get(entityKey);
					results = new TList<KcqHeSoQuyDoiTinChi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqHeSoQuyDoiTinChiSelectMethod.GetAll:
                    results = KcqHeSoQuyDoiTinChiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqHeSoQuyDoiTinChiSelectMethod.GetPaged:
					results = KcqHeSoQuyDoiTinChiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqHeSoQuyDoiTinChiSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqHeSoQuyDoiTinChiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqHeSoQuyDoiTinChiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqHeSoQuyDoiTinChiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqHeSoQuyDoiTinChiProvider.GetById(_id);
					results = new TList<KcqHeSoQuyDoiTinChi>();
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
			if ( SelectMethod == KcqHeSoQuyDoiTinChiSelectMethod.Get || SelectMethod == KcqHeSoQuyDoiTinChiSelectMethod.GetById )
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
				KcqHeSoQuyDoiTinChi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqHeSoQuyDoiTinChiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqHeSoQuyDoiTinChi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqHeSoQuyDoiTinChiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqHeSoQuyDoiTinChiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqHeSoQuyDoiTinChiDataSource class.
	/// </summary>
	public class KcqHeSoQuyDoiTinChiDataSourceDesigner : ProviderDataSourceDesigner<KcqHeSoQuyDoiTinChi, KcqHeSoQuyDoiTinChiKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqHeSoQuyDoiTinChiDataSourceDesigner class.
		/// </summary>
		public KcqHeSoQuyDoiTinChiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHeSoQuyDoiTinChiSelectMethod SelectMethod
		{
			get { return ((KcqHeSoQuyDoiTinChiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqHeSoQuyDoiTinChiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqHeSoQuyDoiTinChiDataSourceActionList

	/// <summary>
	/// Supports the KcqHeSoQuyDoiTinChiDataSourceDesigner class.
	/// </summary>
	internal class KcqHeSoQuyDoiTinChiDataSourceActionList : DesignerActionList
	{
		private KcqHeSoQuyDoiTinChiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqHeSoQuyDoiTinChiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqHeSoQuyDoiTinChiDataSourceActionList(KcqHeSoQuyDoiTinChiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHeSoQuyDoiTinChiSelectMethod SelectMethod
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

	#endregion KcqHeSoQuyDoiTinChiDataSourceActionList
	
	#endregion KcqHeSoQuyDoiTinChiDataSourceDesigner
	
	#region KcqHeSoQuyDoiTinChiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqHeSoQuyDoiTinChiDataSource.SelectMethod property.
	/// </summary>
	public enum KcqHeSoQuyDoiTinChiSelectMethod
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
	
	#endregion KcqHeSoQuyDoiTinChiSelectMethod

	#region KcqHeSoQuyDoiTinChiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoQuyDoiTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoQuyDoiTinChiFilter : SqlFilter<KcqHeSoQuyDoiTinChiColumn>
	{
	}
	
	#endregion KcqHeSoQuyDoiTinChiFilter

	#region KcqHeSoQuyDoiTinChiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoQuyDoiTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoQuyDoiTinChiExpressionBuilder : SqlExpressionBuilder<KcqHeSoQuyDoiTinChiColumn>
	{
	}
	
	#endregion KcqHeSoQuyDoiTinChiExpressionBuilder	

	#region KcqHeSoQuyDoiTinChiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqHeSoQuyDoiTinChiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoQuyDoiTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoQuyDoiTinChiProperty : ChildEntityProperty<KcqHeSoQuyDoiTinChiChildEntityTypes>
	{
	}
	
	#endregion KcqHeSoQuyDoiTinChiProperty
}

