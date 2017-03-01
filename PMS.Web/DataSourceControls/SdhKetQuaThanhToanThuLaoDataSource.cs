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
	/// Represents the DataRepository.SdhKetQuaThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhKetQuaThanhToanThuLaoDataSourceDesigner))]
	public class SdhKetQuaThanhToanThuLaoDataSource : ProviderDataSource<SdhKetQuaThanhToanThuLao, SdhKetQuaThanhToanThuLaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoDataSource class.
		/// </summary>
		public SdhKetQuaThanhToanThuLaoDataSource() : base(new SdhKetQuaThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhKetQuaThanhToanThuLaoDataSourceView used by the SdhKetQuaThanhToanThuLaoDataSource.
		/// </summary>
		protected SdhKetQuaThanhToanThuLaoDataSourceView SdhKetQuaThanhToanThuLaoView
		{
			get { return ( View as SdhKetQuaThanhToanThuLaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhKetQuaThanhToanThuLaoDataSource control invokes to retrieve data.
		/// </summary>
		public SdhKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get
			{
				SdhKetQuaThanhToanThuLaoSelectMethod selectMethod = SdhKetQuaThanhToanThuLaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhKetQuaThanhToanThuLaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhKetQuaThanhToanThuLaoDataSourceView class that is to be
		/// used by the SdhKetQuaThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the SdhKetQuaThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhKetQuaThanhToanThuLao, SdhKetQuaThanhToanThuLaoKey> GetNewDataSourceView()
		{
			return new SdhKetQuaThanhToanThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhKetQuaThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhKetQuaThanhToanThuLaoDataSourceView : ProviderDataSourceView<SdhKetQuaThanhToanThuLao, SdhKetQuaThanhToanThuLaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhKetQuaThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhKetQuaThanhToanThuLaoDataSourceView(SdhKetQuaThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhKetQuaThanhToanThuLaoDataSource SdhKetQuaThanhToanThuLaoOwner
		{
			get { return Owner as SdhKetQuaThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return SdhKetQuaThanhToanThuLaoOwner.SelectMethod; }
			set { SdhKetQuaThanhToanThuLaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhKetQuaThanhToanThuLaoService SdhKetQuaThanhToanThuLaoProvider
		{
			get { return Provider as SdhKetQuaThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhKetQuaThanhToanThuLao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhKetQuaThanhToanThuLao> results = null;
			SdhKetQuaThanhToanThuLao item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case SdhKetQuaThanhToanThuLaoSelectMethod.Get:
					SdhKetQuaThanhToanThuLaoKey entityKey  = new SdhKetQuaThanhToanThuLaoKey();
					entityKey.Load(values);
					item = SdhKetQuaThanhToanThuLaoProvider.Get(entityKey);
					results = new TList<SdhKetQuaThanhToanThuLao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhKetQuaThanhToanThuLaoSelectMethod.GetAll:
                    results = SdhKetQuaThanhToanThuLaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhKetQuaThanhToanThuLaoSelectMethod.GetPaged:
					results = SdhKetQuaThanhToanThuLaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhKetQuaThanhToanThuLaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhKetQuaThanhToanThuLaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhKetQuaThanhToanThuLaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhKetQuaThanhToanThuLaoSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SdhKetQuaThanhToanThuLaoProvider.GetById(_id);
					results = new TList<SdhKetQuaThanhToanThuLao>();
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
			if ( SelectMethod == SdhKetQuaThanhToanThuLaoSelectMethod.Get || SelectMethod == SdhKetQuaThanhToanThuLaoSelectMethod.GetById )
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
				SdhKetQuaThanhToanThuLao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhKetQuaThanhToanThuLaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhKetQuaThanhToanThuLao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhKetQuaThanhToanThuLaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhKetQuaThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhKetQuaThanhToanThuLaoDataSource class.
	/// </summary>
	public class SdhKetQuaThanhToanThuLaoDataSourceDesigner : ProviderDataSourceDesigner<SdhKetQuaThanhToanThuLao, SdhKetQuaThanhToanThuLaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoDataSourceDesigner class.
		/// </summary>
		public SdhKetQuaThanhToanThuLaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ((SdhKetQuaThanhToanThuLaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhKetQuaThanhToanThuLaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhKetQuaThanhToanThuLaoDataSourceActionList

	/// <summary>
	/// Supports the SdhKetQuaThanhToanThuLaoDataSourceDesigner class.
	/// </summary>
	internal class SdhKetQuaThanhToanThuLaoDataSourceActionList : DesignerActionList
	{
		private SdhKetQuaThanhToanThuLaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhKetQuaThanhToanThuLaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhKetQuaThanhToanThuLaoDataSourceActionList(SdhKetQuaThanhToanThuLaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhKetQuaThanhToanThuLaoSelectMethod SelectMethod
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

	#endregion SdhKetQuaThanhToanThuLaoDataSourceActionList
	
	#endregion SdhKetQuaThanhToanThuLaoDataSourceDesigner
	
	#region SdhKetQuaThanhToanThuLaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhKetQuaThanhToanThuLaoDataSource.SelectMethod property.
	/// </summary>
	public enum SdhKetQuaThanhToanThuLaoSelectMethod
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
	
	#endregion SdhKetQuaThanhToanThuLaoSelectMethod

	#region SdhKetQuaThanhToanThuLaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhKetQuaThanhToanThuLaoFilter : SqlFilter<SdhKetQuaThanhToanThuLaoColumn>
	{
	}
	
	#endregion SdhKetQuaThanhToanThuLaoFilter

	#region SdhKetQuaThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhKetQuaThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<SdhKetQuaThanhToanThuLaoColumn>
	{
	}
	
	#endregion SdhKetQuaThanhToanThuLaoExpressionBuilder	

	#region SdhKetQuaThanhToanThuLaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhKetQuaThanhToanThuLaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhKetQuaThanhToanThuLaoProperty : ChildEntityProperty<SdhKetQuaThanhToanThuLaoChildEntityTypes>
	{
	}
	
	#endregion SdhKetQuaThanhToanThuLaoProperty
}

