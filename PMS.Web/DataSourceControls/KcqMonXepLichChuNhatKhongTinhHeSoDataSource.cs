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
	/// Represents the DataRepository.KcqMonXepLichChuNhatKhongTinhHeSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner))]
	public class KcqMonXepLichChuNhatKhongTinhHeSoDataSource : ProviderDataSource<KcqMonXepLichChuNhatKhongTinhHeSo, KcqMonXepLichChuNhatKhongTinhHeSoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonXepLichChuNhatKhongTinhHeSoDataSource class.
		/// </summary>
		public KcqMonXepLichChuNhatKhongTinhHeSoDataSource() : base(new KcqMonXepLichChuNhatKhongTinhHeSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView used by the KcqMonXepLichChuNhatKhongTinhHeSoDataSource.
		/// </summary>
		protected KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView KcqMonXepLichChuNhatKhongTinhHeSoView
		{
			get { return ( View as KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqMonXepLichChuNhatKhongTinhHeSoDataSource control invokes to retrieve data.
		/// </summary>
		public KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get
			{
				KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod selectMethod = KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView class that is to be
		/// used by the KcqMonXepLichChuNhatKhongTinhHeSoDataSource.
		/// </summary>
		/// <returns>An instance of the KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqMonXepLichChuNhatKhongTinhHeSo, KcqMonXepLichChuNhatKhongTinhHeSoKey> GetNewDataSourceView()
		{
			return new KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqMonXepLichChuNhatKhongTinhHeSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView : ProviderDataSourceView<KcqMonXepLichChuNhatKhongTinhHeSo, KcqMonXepLichChuNhatKhongTinhHeSoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqMonXepLichChuNhatKhongTinhHeSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqMonXepLichChuNhatKhongTinhHeSoDataSourceView(KcqMonXepLichChuNhatKhongTinhHeSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqMonXepLichChuNhatKhongTinhHeSoDataSource KcqMonXepLichChuNhatKhongTinhHeSoOwner
		{
			get { return Owner as KcqMonXepLichChuNhatKhongTinhHeSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get { return KcqMonXepLichChuNhatKhongTinhHeSoOwner.SelectMethod; }
			set { KcqMonXepLichChuNhatKhongTinhHeSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqMonXepLichChuNhatKhongTinhHeSoService KcqMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get { return Provider as KcqMonXepLichChuNhatKhongTinhHeSoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqMonXepLichChuNhatKhongTinhHeSo> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqMonXepLichChuNhatKhongTinhHeSo> results = null;
			KcqMonXepLichChuNhatKhongTinhHeSo item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod.Get:
					KcqMonXepLichChuNhatKhongTinhHeSoKey entityKey  = new KcqMonXepLichChuNhatKhongTinhHeSoKey();
					entityKey.Load(values);
					item = KcqMonXepLichChuNhatKhongTinhHeSoProvider.Get(entityKey);
					results = new TList<KcqMonXepLichChuNhatKhongTinhHeSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetAll:
                    results = KcqMonXepLichChuNhatKhongTinhHeSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetPaged:
					results = KcqMonXepLichChuNhatKhongTinhHeSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqMonXepLichChuNhatKhongTinhHeSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqMonXepLichChuNhatKhongTinhHeSoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqMonXepLichChuNhatKhongTinhHeSoProvider.GetById(_id);
					results = new TList<KcqMonXepLichChuNhatKhongTinhHeSo>();
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
			if ( SelectMethod == KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod.Get || SelectMethod == KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod.GetById )
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
				KcqMonXepLichChuNhatKhongTinhHeSo entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqMonXepLichChuNhatKhongTinhHeSoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqMonXepLichChuNhatKhongTinhHeSo> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqMonXepLichChuNhatKhongTinhHeSoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqMonXepLichChuNhatKhongTinhHeSoDataSource class.
	/// </summary>
	public class KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner : ProviderDataSourceDesigner<KcqMonXepLichChuNhatKhongTinhHeSo, KcqMonXepLichChuNhatKhongTinhHeSoKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner class.
		/// </summary>
		public KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get { return ((KcqMonXepLichChuNhatKhongTinhHeSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqMonXepLichChuNhatKhongTinhHeSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqMonXepLichChuNhatKhongTinhHeSoDataSourceActionList

	/// <summary>
	/// Supports the KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner class.
	/// </summary>
	internal class KcqMonXepLichChuNhatKhongTinhHeSoDataSourceActionList : DesignerActionList
	{
		private KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqMonXepLichChuNhatKhongTinhHeSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqMonXepLichChuNhatKhongTinhHeSoDataSourceActionList(KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
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

	#endregion KcqMonXepLichChuNhatKhongTinhHeSoDataSourceActionList
	
	#endregion KcqMonXepLichChuNhatKhongTinhHeSoDataSourceDesigner
	
	#region KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqMonXepLichChuNhatKhongTinhHeSoDataSource.SelectMethod property.
	/// </summary>
	public enum KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod
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
	
	#endregion KcqMonXepLichChuNhatKhongTinhHeSoSelectMethod

	#region KcqMonXepLichChuNhatKhongTinhHeSoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonXepLichChuNhatKhongTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonXepLichChuNhatKhongTinhHeSoFilter : SqlFilter<KcqMonXepLichChuNhatKhongTinhHeSoColumn>
	{
	}
	
	#endregion KcqMonXepLichChuNhatKhongTinhHeSoFilter

	#region KcqMonXepLichChuNhatKhongTinhHeSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonXepLichChuNhatKhongTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonXepLichChuNhatKhongTinhHeSoExpressionBuilder : SqlExpressionBuilder<KcqMonXepLichChuNhatKhongTinhHeSoColumn>
	{
	}
	
	#endregion KcqMonXepLichChuNhatKhongTinhHeSoExpressionBuilder	

	#region KcqMonXepLichChuNhatKhongTinhHeSoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqMonXepLichChuNhatKhongTinhHeSoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonXepLichChuNhatKhongTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonXepLichChuNhatKhongTinhHeSoProperty : ChildEntityProperty<KcqMonXepLichChuNhatKhongTinhHeSoChildEntityTypes>
	{
	}
	
	#endregion KcqMonXepLichChuNhatKhongTinhHeSoProperty
}

