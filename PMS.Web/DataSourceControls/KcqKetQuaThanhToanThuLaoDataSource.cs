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
	/// Represents the DataRepository.KcqKetQuaThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqKetQuaThanhToanThuLaoDataSourceDesigner))]
	public class KcqKetQuaThanhToanThuLaoDataSource : ProviderDataSource<KcqKetQuaThanhToanThuLao, KcqKetQuaThanhToanThuLaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoDataSource class.
		/// </summary>
		public KcqKetQuaThanhToanThuLaoDataSource() : base(new KcqKetQuaThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqKetQuaThanhToanThuLaoDataSourceView used by the KcqKetQuaThanhToanThuLaoDataSource.
		/// </summary>
		protected KcqKetQuaThanhToanThuLaoDataSourceView KcqKetQuaThanhToanThuLaoView
		{
			get { return ( View as KcqKetQuaThanhToanThuLaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqKetQuaThanhToanThuLaoDataSource control invokes to retrieve data.
		/// </summary>
		public KcqKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get
			{
				KcqKetQuaThanhToanThuLaoSelectMethod selectMethod = KcqKetQuaThanhToanThuLaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqKetQuaThanhToanThuLaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqKetQuaThanhToanThuLaoDataSourceView class that is to be
		/// used by the KcqKetQuaThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the KcqKetQuaThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqKetQuaThanhToanThuLao, KcqKetQuaThanhToanThuLaoKey> GetNewDataSourceView()
		{
			return new KcqKetQuaThanhToanThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqKetQuaThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqKetQuaThanhToanThuLaoDataSourceView : ProviderDataSourceView<KcqKetQuaThanhToanThuLao, KcqKetQuaThanhToanThuLaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqKetQuaThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqKetQuaThanhToanThuLaoDataSourceView(KcqKetQuaThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqKetQuaThanhToanThuLaoDataSource KcqKetQuaThanhToanThuLaoOwner
		{
			get { return Owner as KcqKetQuaThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return KcqKetQuaThanhToanThuLaoOwner.SelectMethod; }
			set { KcqKetQuaThanhToanThuLaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqKetQuaThanhToanThuLaoService KcqKetQuaThanhToanThuLaoProvider
		{
			get { return Provider as KcqKetQuaThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqKetQuaThanhToanThuLao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqKetQuaThanhToanThuLao> results = null;
			KcqKetQuaThanhToanThuLao item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqKetQuaThanhToanThuLaoSelectMethod.Get:
					KcqKetQuaThanhToanThuLaoKey entityKey  = new KcqKetQuaThanhToanThuLaoKey();
					entityKey.Load(values);
					item = KcqKetQuaThanhToanThuLaoProvider.Get(entityKey);
					results = new TList<KcqKetQuaThanhToanThuLao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqKetQuaThanhToanThuLaoSelectMethod.GetAll:
                    results = KcqKetQuaThanhToanThuLaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqKetQuaThanhToanThuLaoSelectMethod.GetPaged:
					results = KcqKetQuaThanhToanThuLaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqKetQuaThanhToanThuLaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqKetQuaThanhToanThuLaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqKetQuaThanhToanThuLaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqKetQuaThanhToanThuLaoSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqKetQuaThanhToanThuLaoProvider.GetById(_id);
					results = new TList<KcqKetQuaThanhToanThuLao>();
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
			if ( SelectMethod == KcqKetQuaThanhToanThuLaoSelectMethod.Get || SelectMethod == KcqKetQuaThanhToanThuLaoSelectMethod.GetById )
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
				KcqKetQuaThanhToanThuLao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqKetQuaThanhToanThuLaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqKetQuaThanhToanThuLao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqKetQuaThanhToanThuLaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqKetQuaThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqKetQuaThanhToanThuLaoDataSource class.
	/// </summary>
	public class KcqKetQuaThanhToanThuLaoDataSourceDesigner : ProviderDataSourceDesigner<KcqKetQuaThanhToanThuLao, KcqKetQuaThanhToanThuLaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoDataSourceDesigner class.
		/// </summary>
		public KcqKetQuaThanhToanThuLaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ((KcqKetQuaThanhToanThuLaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqKetQuaThanhToanThuLaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqKetQuaThanhToanThuLaoDataSourceActionList

	/// <summary>
	/// Supports the KcqKetQuaThanhToanThuLaoDataSourceDesigner class.
	/// </summary>
	internal class KcqKetQuaThanhToanThuLaoDataSourceActionList : DesignerActionList
	{
		private KcqKetQuaThanhToanThuLaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqKetQuaThanhToanThuLaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqKetQuaThanhToanThuLaoDataSourceActionList(KcqKetQuaThanhToanThuLaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKetQuaThanhToanThuLaoSelectMethod SelectMethod
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

	#endregion KcqKetQuaThanhToanThuLaoDataSourceActionList
	
	#endregion KcqKetQuaThanhToanThuLaoDataSourceDesigner
	
	#region KcqKetQuaThanhToanThuLaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqKetQuaThanhToanThuLaoDataSource.SelectMethod property.
	/// </summary>
	public enum KcqKetQuaThanhToanThuLaoSelectMethod
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
	
	#endregion KcqKetQuaThanhToanThuLaoSelectMethod

	#region KcqKetQuaThanhToanThuLaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKetQuaThanhToanThuLaoFilter : SqlFilter<KcqKetQuaThanhToanThuLaoColumn>
	{
	}
	
	#endregion KcqKetQuaThanhToanThuLaoFilter

	#region KcqKetQuaThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKetQuaThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<KcqKetQuaThanhToanThuLaoColumn>
	{
	}
	
	#endregion KcqKetQuaThanhToanThuLaoExpressionBuilder	

	#region KcqKetQuaThanhToanThuLaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqKetQuaThanhToanThuLaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKetQuaThanhToanThuLaoProperty : ChildEntityProperty<KcqKetQuaThanhToanThuLaoChildEntityTypes>
	{
	}
	
	#endregion KcqKetQuaThanhToanThuLaoProperty
}

