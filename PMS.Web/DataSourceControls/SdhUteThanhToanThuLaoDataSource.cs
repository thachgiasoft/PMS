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
	/// Represents the DataRepository.SdhUteThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhUteThanhToanThuLaoDataSourceDesigner))]
	public class SdhUteThanhToanThuLaoDataSource : ProviderDataSource<SdhUteThanhToanThuLao, SdhUteThanhToanThuLaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoDataSource class.
		/// </summary>
		public SdhUteThanhToanThuLaoDataSource() : base(new SdhUteThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhUteThanhToanThuLaoDataSourceView used by the SdhUteThanhToanThuLaoDataSource.
		/// </summary>
		protected SdhUteThanhToanThuLaoDataSourceView SdhUteThanhToanThuLaoView
		{
			get { return ( View as SdhUteThanhToanThuLaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhUteThanhToanThuLaoDataSource control invokes to retrieve data.
		/// </summary>
		public SdhUteThanhToanThuLaoSelectMethod SelectMethod
		{
			get
			{
				SdhUteThanhToanThuLaoSelectMethod selectMethod = SdhUteThanhToanThuLaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhUteThanhToanThuLaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhUteThanhToanThuLaoDataSourceView class that is to be
		/// used by the SdhUteThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the SdhUteThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhUteThanhToanThuLao, SdhUteThanhToanThuLaoKey> GetNewDataSourceView()
		{
			return new SdhUteThanhToanThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhUteThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhUteThanhToanThuLaoDataSourceView : ProviderDataSourceView<SdhUteThanhToanThuLao, SdhUteThanhToanThuLaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhUteThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhUteThanhToanThuLaoDataSourceView(SdhUteThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhUteThanhToanThuLaoDataSource SdhUteThanhToanThuLaoOwner
		{
			get { return Owner as SdhUteThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhUteThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return SdhUteThanhToanThuLaoOwner.SelectMethod; }
			set { SdhUteThanhToanThuLaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhUteThanhToanThuLaoService SdhUteThanhToanThuLaoProvider
		{
			get { return Provider as SdhUteThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhUteThanhToanThuLao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhUteThanhToanThuLao> results = null;
			SdhUteThanhToanThuLao item;
			count = 0;
			
			System.Int32 _idKhoiLuongQuyDoi;

			switch ( SelectMethod )
			{
				case SdhUteThanhToanThuLaoSelectMethod.Get:
					SdhUteThanhToanThuLaoKey entityKey  = new SdhUteThanhToanThuLaoKey();
					entityKey.Load(values);
					item = SdhUteThanhToanThuLaoProvider.Get(entityKey);
					results = new TList<SdhUteThanhToanThuLao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhUteThanhToanThuLaoSelectMethod.GetAll:
                    results = SdhUteThanhToanThuLaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhUteThanhToanThuLaoSelectMethod.GetPaged:
					results = SdhUteThanhToanThuLaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhUteThanhToanThuLaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhUteThanhToanThuLaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhUteThanhToanThuLaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhUteThanhToanThuLaoSelectMethod.GetByIdKhoiLuongQuyDoi:
					_idKhoiLuongQuyDoi = ( values["IdKhoiLuongQuyDoi"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["IdKhoiLuongQuyDoi"], typeof(System.Int32)) : (int)0;
					item = SdhUteThanhToanThuLaoProvider.GetByIdKhoiLuongQuyDoi(_idKhoiLuongQuyDoi);
					results = new TList<SdhUteThanhToanThuLao>();
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
			if ( SelectMethod == SdhUteThanhToanThuLaoSelectMethod.Get || SelectMethod == SdhUteThanhToanThuLaoSelectMethod.GetByIdKhoiLuongQuyDoi )
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
				SdhUteThanhToanThuLao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhUteThanhToanThuLaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhUteThanhToanThuLao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhUteThanhToanThuLaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhUteThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhUteThanhToanThuLaoDataSource class.
	/// </summary>
	public class SdhUteThanhToanThuLaoDataSourceDesigner : ProviderDataSourceDesigner<SdhUteThanhToanThuLao, SdhUteThanhToanThuLaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoDataSourceDesigner class.
		/// </summary>
		public SdhUteThanhToanThuLaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhUteThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ((SdhUteThanhToanThuLaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhUteThanhToanThuLaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhUteThanhToanThuLaoDataSourceActionList

	/// <summary>
	/// Supports the SdhUteThanhToanThuLaoDataSourceDesigner class.
	/// </summary>
	internal class SdhUteThanhToanThuLaoDataSourceActionList : DesignerActionList
	{
		private SdhUteThanhToanThuLaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhUteThanhToanThuLaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhUteThanhToanThuLaoDataSourceActionList(SdhUteThanhToanThuLaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhUteThanhToanThuLaoSelectMethod SelectMethod
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

	#endregion SdhUteThanhToanThuLaoDataSourceActionList
	
	#endregion SdhUteThanhToanThuLaoDataSourceDesigner
	
	#region SdhUteThanhToanThuLaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhUteThanhToanThuLaoDataSource.SelectMethod property.
	/// </summary>
	public enum SdhUteThanhToanThuLaoSelectMethod
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
		/// Represents the GetByIdKhoiLuongQuyDoi method.
		/// </summary>
		GetByIdKhoiLuongQuyDoi
	}
	
	#endregion SdhUteThanhToanThuLaoSelectMethod

	#region SdhUteThanhToanThuLaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteThanhToanThuLaoFilter : SqlFilter<SdhUteThanhToanThuLaoColumn>
	{
	}
	
	#endregion SdhUteThanhToanThuLaoFilter

	#region SdhUteThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<SdhUteThanhToanThuLaoColumn>
	{
	}
	
	#endregion SdhUteThanhToanThuLaoExpressionBuilder	

	#region SdhUteThanhToanThuLaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhUteThanhToanThuLaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteThanhToanThuLaoProperty : ChildEntityProperty<SdhUteThanhToanThuLaoChildEntityTypes>
	{
	}
	
	#endregion SdhUteThanhToanThuLaoProperty
}

