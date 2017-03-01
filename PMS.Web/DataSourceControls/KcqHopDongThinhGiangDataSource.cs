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
	/// Represents the DataRepository.KcqHopDongThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqHopDongThinhGiangDataSourceDesigner))]
	public class KcqHopDongThinhGiangDataSource : ProviderDataSource<KcqHopDongThinhGiang, KcqHopDongThinhGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHopDongThinhGiangDataSource class.
		/// </summary>
		public KcqHopDongThinhGiangDataSource() : base(new KcqHopDongThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqHopDongThinhGiangDataSourceView used by the KcqHopDongThinhGiangDataSource.
		/// </summary>
		protected KcqHopDongThinhGiangDataSourceView KcqHopDongThinhGiangView
		{
			get { return ( View as KcqHopDongThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqHopDongThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public KcqHopDongThinhGiangSelectMethod SelectMethod
		{
			get
			{
				KcqHopDongThinhGiangSelectMethod selectMethod = KcqHopDongThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqHopDongThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqHopDongThinhGiangDataSourceView class that is to be
		/// used by the KcqHopDongThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the KcqHopDongThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqHopDongThinhGiang, KcqHopDongThinhGiangKey> GetNewDataSourceView()
		{
			return new KcqHopDongThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqHopDongThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqHopDongThinhGiangDataSourceView : ProviderDataSourceView<KcqHopDongThinhGiang, KcqHopDongThinhGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHopDongThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqHopDongThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqHopDongThinhGiangDataSourceView(KcqHopDongThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqHopDongThinhGiangDataSource KcqHopDongThinhGiangOwner
		{
			get { return Owner as KcqHopDongThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return KcqHopDongThinhGiangOwner.SelectMethod; }
			set { KcqHopDongThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqHopDongThinhGiangService KcqHopDongThinhGiangProvider
		{
			get { return Provider as KcqHopDongThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqHopDongThinhGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqHopDongThinhGiang> results = null;
			KcqHopDongThinhGiang item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqHopDongThinhGiangSelectMethod.Get:
					KcqHopDongThinhGiangKey entityKey  = new KcqHopDongThinhGiangKey();
					entityKey.Load(values);
					item = KcqHopDongThinhGiangProvider.Get(entityKey);
					results = new TList<KcqHopDongThinhGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqHopDongThinhGiangSelectMethod.GetAll:
                    results = KcqHopDongThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqHopDongThinhGiangSelectMethod.GetPaged:
					results = KcqHopDongThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqHopDongThinhGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqHopDongThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqHopDongThinhGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqHopDongThinhGiangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqHopDongThinhGiangProvider.GetById(_id);
					results = new TList<KcqHopDongThinhGiang>();
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
			if ( SelectMethod == KcqHopDongThinhGiangSelectMethod.Get || SelectMethod == KcqHopDongThinhGiangSelectMethod.GetById )
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
				KcqHopDongThinhGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqHopDongThinhGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqHopDongThinhGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqHopDongThinhGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqHopDongThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqHopDongThinhGiangDataSource class.
	/// </summary>
	public class KcqHopDongThinhGiangDataSourceDesigner : ProviderDataSourceDesigner<KcqHopDongThinhGiang, KcqHopDongThinhGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqHopDongThinhGiangDataSourceDesigner class.
		/// </summary>
		public KcqHopDongThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ((KcqHopDongThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqHopDongThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqHopDongThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the KcqHopDongThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class KcqHopDongThinhGiangDataSourceActionList : DesignerActionList
	{
		private KcqHopDongThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqHopDongThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqHopDongThinhGiangDataSourceActionList(KcqHopDongThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHopDongThinhGiangSelectMethod SelectMethod
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

	#endregion KcqHopDongThinhGiangDataSourceActionList
	
	#endregion KcqHopDongThinhGiangDataSourceDesigner
	
	#region KcqHopDongThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqHopDongThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum KcqHopDongThinhGiangSelectMethod
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
	
	#endregion KcqHopDongThinhGiangSelectMethod

	#region KcqHopDongThinhGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHopDongThinhGiangFilter : SqlFilter<KcqHopDongThinhGiangColumn>
	{
	}
	
	#endregion KcqHopDongThinhGiangFilter

	#region KcqHopDongThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHopDongThinhGiangExpressionBuilder : SqlExpressionBuilder<KcqHopDongThinhGiangColumn>
	{
	}
	
	#endregion KcqHopDongThinhGiangExpressionBuilder	

	#region KcqHopDongThinhGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqHopDongThinhGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHopDongThinhGiangProperty : ChildEntityProperty<KcqHopDongThinhGiangChildEntityTypes>
	{
	}
	
	#endregion KcqHopDongThinhGiangProperty
}

