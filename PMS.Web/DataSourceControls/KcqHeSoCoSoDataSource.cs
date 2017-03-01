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
	/// Represents the DataRepository.KcqHeSoCoSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqHeSoCoSoDataSourceDesigner))]
	public class KcqHeSoCoSoDataSource : ProviderDataSource<KcqHeSoCoSo, KcqHeSoCoSoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoCoSoDataSource class.
		/// </summary>
		public KcqHeSoCoSoDataSource() : base(new KcqHeSoCoSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqHeSoCoSoDataSourceView used by the KcqHeSoCoSoDataSource.
		/// </summary>
		protected KcqHeSoCoSoDataSourceView KcqHeSoCoSoView
		{
			get { return ( View as KcqHeSoCoSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqHeSoCoSoDataSource control invokes to retrieve data.
		/// </summary>
		public KcqHeSoCoSoSelectMethod SelectMethod
		{
			get
			{
				KcqHeSoCoSoSelectMethod selectMethod = KcqHeSoCoSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqHeSoCoSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqHeSoCoSoDataSourceView class that is to be
		/// used by the KcqHeSoCoSoDataSource.
		/// </summary>
		/// <returns>An instance of the KcqHeSoCoSoDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqHeSoCoSo, KcqHeSoCoSoKey> GetNewDataSourceView()
		{
			return new KcqHeSoCoSoDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqHeSoCoSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqHeSoCoSoDataSourceView : ProviderDataSourceView<KcqHeSoCoSo, KcqHeSoCoSoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoCoSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqHeSoCoSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqHeSoCoSoDataSourceView(KcqHeSoCoSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqHeSoCoSoDataSource KcqHeSoCoSoOwner
		{
			get { return Owner as KcqHeSoCoSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqHeSoCoSoSelectMethod SelectMethod
		{
			get { return KcqHeSoCoSoOwner.SelectMethod; }
			set { KcqHeSoCoSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqHeSoCoSoService KcqHeSoCoSoProvider
		{
			get { return Provider as KcqHeSoCoSoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqHeSoCoSo> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqHeSoCoSo> results = null;
			KcqHeSoCoSo item;
			count = 0;
			
			System.Int32 _maHeSo;

			switch ( SelectMethod )
			{
				case KcqHeSoCoSoSelectMethod.Get:
					KcqHeSoCoSoKey entityKey  = new KcqHeSoCoSoKey();
					entityKey.Load(values);
					item = KcqHeSoCoSoProvider.Get(entityKey);
					results = new TList<KcqHeSoCoSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqHeSoCoSoSelectMethod.GetAll:
                    results = KcqHeSoCoSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqHeSoCoSoSelectMethod.GetPaged:
					results = KcqHeSoCoSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqHeSoCoSoSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqHeSoCoSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqHeSoCoSoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqHeSoCoSoSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = KcqHeSoCoSoProvider.GetByMaHeSo(_maHeSo);
					results = new TList<KcqHeSoCoSo>();
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
			if ( SelectMethod == KcqHeSoCoSoSelectMethod.Get || SelectMethod == KcqHeSoCoSoSelectMethod.GetByMaHeSo )
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
				KcqHeSoCoSo entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqHeSoCoSoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqHeSoCoSo> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqHeSoCoSoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqHeSoCoSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqHeSoCoSoDataSource class.
	/// </summary>
	public class KcqHeSoCoSoDataSourceDesigner : ProviderDataSourceDesigner<KcqHeSoCoSo, KcqHeSoCoSoKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqHeSoCoSoDataSourceDesigner class.
		/// </summary>
		public KcqHeSoCoSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHeSoCoSoSelectMethod SelectMethod
		{
			get { return ((KcqHeSoCoSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqHeSoCoSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqHeSoCoSoDataSourceActionList

	/// <summary>
	/// Supports the KcqHeSoCoSoDataSourceDesigner class.
	/// </summary>
	internal class KcqHeSoCoSoDataSourceActionList : DesignerActionList
	{
		private KcqHeSoCoSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqHeSoCoSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqHeSoCoSoDataSourceActionList(KcqHeSoCoSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHeSoCoSoSelectMethod SelectMethod
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

	#endregion KcqHeSoCoSoDataSourceActionList
	
	#endregion KcqHeSoCoSoDataSourceDesigner
	
	#region KcqHeSoCoSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqHeSoCoSoDataSource.SelectMethod property.
	/// </summary>
	public enum KcqHeSoCoSoSelectMethod
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
		/// Represents the GetByMaHeSo method.
		/// </summary>
		GetByMaHeSo
	}
	
	#endregion KcqHeSoCoSoSelectMethod

	#region KcqHeSoCoSoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoCoSoFilter : SqlFilter<KcqHeSoCoSoColumn>
	{
	}
	
	#endregion KcqHeSoCoSoFilter

	#region KcqHeSoCoSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoCoSoExpressionBuilder : SqlExpressionBuilder<KcqHeSoCoSoColumn>
	{
	}
	
	#endregion KcqHeSoCoSoExpressionBuilder	

	#region KcqHeSoCoSoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqHeSoCoSoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoCoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoCoSoProperty : ChildEntityProperty<KcqHeSoCoSoChildEntityTypes>
	{
	}
	
	#endregion KcqHeSoCoSoProperty
}

