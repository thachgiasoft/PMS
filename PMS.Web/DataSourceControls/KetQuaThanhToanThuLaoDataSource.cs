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
	/// Represents the DataRepository.KetQuaThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KetQuaThanhToanThuLaoDataSourceDesigner))]
	public class KetQuaThanhToanThuLaoDataSource : ProviderDataSource<KetQuaThanhToanThuLao, KetQuaThanhToanThuLaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoDataSource class.
		/// </summary>
		public KetQuaThanhToanThuLaoDataSource() : base(new KetQuaThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KetQuaThanhToanThuLaoDataSourceView used by the KetQuaThanhToanThuLaoDataSource.
		/// </summary>
		protected KetQuaThanhToanThuLaoDataSourceView KetQuaThanhToanThuLaoView
		{
			get { return ( View as KetQuaThanhToanThuLaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KetQuaThanhToanThuLaoDataSource control invokes to retrieve data.
		/// </summary>
		public KetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get
			{
				KetQuaThanhToanThuLaoSelectMethod selectMethod = KetQuaThanhToanThuLaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KetQuaThanhToanThuLaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KetQuaThanhToanThuLaoDataSourceView class that is to be
		/// used by the KetQuaThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the KetQuaThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<KetQuaThanhToanThuLao, KetQuaThanhToanThuLaoKey> GetNewDataSourceView()
		{
			return new KetQuaThanhToanThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the KetQuaThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KetQuaThanhToanThuLaoDataSourceView : ProviderDataSourceView<KetQuaThanhToanThuLao, KetQuaThanhToanThuLaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KetQuaThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KetQuaThanhToanThuLaoDataSourceView(KetQuaThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KetQuaThanhToanThuLaoDataSource KetQuaThanhToanThuLaoOwner
		{
			get { return Owner as KetQuaThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return KetQuaThanhToanThuLaoOwner.SelectMethod; }
			set { KetQuaThanhToanThuLaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KetQuaThanhToanThuLaoService KetQuaThanhToanThuLaoProvider
		{
			get { return Provider as KetQuaThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KetQuaThanhToanThuLao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KetQuaThanhToanThuLao> results = null;
			KetQuaThanhToanThuLao item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KetQuaThanhToanThuLaoSelectMethod.Get:
					KetQuaThanhToanThuLaoKey entityKey  = new KetQuaThanhToanThuLaoKey();
					entityKey.Load(values);
					item = KetQuaThanhToanThuLaoProvider.Get(entityKey);
					results = new TList<KetQuaThanhToanThuLao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KetQuaThanhToanThuLaoSelectMethod.GetAll:
                    results = KetQuaThanhToanThuLaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KetQuaThanhToanThuLaoSelectMethod.GetPaged:
					results = KetQuaThanhToanThuLaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KetQuaThanhToanThuLaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = KetQuaThanhToanThuLaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KetQuaThanhToanThuLaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KetQuaThanhToanThuLaoSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KetQuaThanhToanThuLaoProvider.GetById(_id);
					results = new TList<KetQuaThanhToanThuLao>();
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
			if ( SelectMethod == KetQuaThanhToanThuLaoSelectMethod.Get || SelectMethod == KetQuaThanhToanThuLaoSelectMethod.GetById )
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
				KetQuaThanhToanThuLao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KetQuaThanhToanThuLaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KetQuaThanhToanThuLao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KetQuaThanhToanThuLaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KetQuaThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KetQuaThanhToanThuLaoDataSource class.
	/// </summary>
	public class KetQuaThanhToanThuLaoDataSourceDesigner : ProviderDataSourceDesigner<KetQuaThanhToanThuLao, KetQuaThanhToanThuLaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoDataSourceDesigner class.
		/// </summary>
		public KetQuaThanhToanThuLaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ((KetQuaThanhToanThuLaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KetQuaThanhToanThuLaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KetQuaThanhToanThuLaoDataSourceActionList

	/// <summary>
	/// Supports the KetQuaThanhToanThuLaoDataSourceDesigner class.
	/// </summary>
	internal class KetQuaThanhToanThuLaoDataSourceActionList : DesignerActionList
	{
		private KetQuaThanhToanThuLaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KetQuaThanhToanThuLaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KetQuaThanhToanThuLaoDataSourceActionList(KetQuaThanhToanThuLaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaThanhToanThuLaoSelectMethod SelectMethod
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

	#endregion KetQuaThanhToanThuLaoDataSourceActionList
	
	#endregion KetQuaThanhToanThuLaoDataSourceDesigner
	
	#region KetQuaThanhToanThuLaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KetQuaThanhToanThuLaoDataSource.SelectMethod property.
	/// </summary>
	public enum KetQuaThanhToanThuLaoSelectMethod
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
	
	#endregion KetQuaThanhToanThuLaoSelectMethod

	#region KetQuaThanhToanThuLaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaThanhToanThuLaoFilter : SqlFilter<KetQuaThanhToanThuLaoColumn>
	{
	}
	
	#endregion KetQuaThanhToanThuLaoFilter

	#region KetQuaThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<KetQuaThanhToanThuLaoColumn>
	{
	}
	
	#endregion KetQuaThanhToanThuLaoExpressionBuilder	

	#region KetQuaThanhToanThuLaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KetQuaThanhToanThuLaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaThanhToanThuLaoProperty : ChildEntityProperty<KetQuaThanhToanThuLaoChildEntityTypes>
	{
	}
	
	#endregion KetQuaThanhToanThuLaoProperty
}

