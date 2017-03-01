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
	/// Represents the DataRepository.ChiTienThuLaoGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ChiTienThuLaoGiangDayDataSourceDesigner))]
	public class ChiTienThuLaoGiangDayDataSource : ProviderDataSource<ChiTienThuLaoGiangDay, ChiTienThuLaoGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayDataSource class.
		/// </summary>
		public ChiTienThuLaoGiangDayDataSource() : base(new ChiTienThuLaoGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ChiTienThuLaoGiangDayDataSourceView used by the ChiTienThuLaoGiangDayDataSource.
		/// </summary>
		protected ChiTienThuLaoGiangDayDataSourceView ChiTienThuLaoGiangDayView
		{
			get { return ( View as ChiTienThuLaoGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ChiTienThuLaoGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public ChiTienThuLaoGiangDaySelectMethod SelectMethod
		{
			get
			{
				ChiTienThuLaoGiangDaySelectMethod selectMethod = ChiTienThuLaoGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ChiTienThuLaoGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ChiTienThuLaoGiangDayDataSourceView class that is to be
		/// used by the ChiTienThuLaoGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ChiTienThuLaoGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ChiTienThuLaoGiangDay, ChiTienThuLaoGiangDayKey> GetNewDataSourceView()
		{
			return new ChiTienThuLaoGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ChiTienThuLaoGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ChiTienThuLaoGiangDayDataSourceView : ProviderDataSourceView<ChiTienThuLaoGiangDay, ChiTienThuLaoGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ChiTienThuLaoGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ChiTienThuLaoGiangDayDataSourceView(ChiTienThuLaoGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ChiTienThuLaoGiangDayDataSource ChiTienThuLaoGiangDayOwner
		{
			get { return Owner as ChiTienThuLaoGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ChiTienThuLaoGiangDaySelectMethod SelectMethod
		{
			get { return ChiTienThuLaoGiangDayOwner.SelectMethod; }
			set { ChiTienThuLaoGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ChiTienThuLaoGiangDayService ChiTienThuLaoGiangDayProvider
		{
			get { return Provider as ChiTienThuLaoGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ChiTienThuLaoGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ChiTienThuLaoGiangDay> results = null;
			ChiTienThuLaoGiangDay item;
			count = 0;
			
			System.Guid? _oid_nullable;
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ChiTienThuLaoGiangDaySelectMethod.Get:
					ChiTienThuLaoGiangDayKey entityKey  = new ChiTienThuLaoGiangDayKey();
					entityKey.Load(values);
					item = ChiTienThuLaoGiangDayProvider.Get(entityKey);
					results = new TList<ChiTienThuLaoGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ChiTienThuLaoGiangDaySelectMethod.GetAll:
                    results = ChiTienThuLaoGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ChiTienThuLaoGiangDaySelectMethod.GetPaged:
					results = ChiTienThuLaoGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ChiTienThuLaoGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = ChiTienThuLaoGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ChiTienThuLaoGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ChiTienThuLaoGiangDaySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ChiTienThuLaoGiangDayProvider.GetById(_id);
					results = new TList<ChiTienThuLaoGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case ChiTienThuLaoGiangDaySelectMethod.GetByOid:
					_oid_nullable = (System.Guid?) EntityUtil.ChangeType(values["Oid"], typeof(System.Guid?));
					results = ChiTienThuLaoGiangDayProvider.GetByOid(_oid_nullable, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == ChiTienThuLaoGiangDaySelectMethod.Get || SelectMethod == ChiTienThuLaoGiangDaySelectMethod.GetById )
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
				ChiTienThuLaoGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ChiTienThuLaoGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ChiTienThuLaoGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ChiTienThuLaoGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ChiTienThuLaoGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ChiTienThuLaoGiangDayDataSource class.
	/// </summary>
	public class ChiTienThuLaoGiangDayDataSourceDesigner : ProviderDataSourceDesigner<ChiTienThuLaoGiangDay, ChiTienThuLaoGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayDataSourceDesigner class.
		/// </summary>
		public ChiTienThuLaoGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChiTienThuLaoGiangDaySelectMethod SelectMethod
		{
			get { return ((ChiTienThuLaoGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ChiTienThuLaoGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ChiTienThuLaoGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ChiTienThuLaoGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ChiTienThuLaoGiangDayDataSourceActionList : DesignerActionList
	{
		private ChiTienThuLaoGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ChiTienThuLaoGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ChiTienThuLaoGiangDayDataSourceActionList(ChiTienThuLaoGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChiTienThuLaoGiangDaySelectMethod SelectMethod
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

	#endregion ChiTienThuLaoGiangDayDataSourceActionList
	
	#endregion ChiTienThuLaoGiangDayDataSourceDesigner
	
	#region ChiTienThuLaoGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ChiTienThuLaoGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ChiTienThuLaoGiangDaySelectMethod
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
		/// Represents the GetByOid method.
		/// </summary>
		GetByOid,
		/// <summary>
		/// Represents the GetById method.
		/// </summary>
		GetById
	}
	
	#endregion ChiTienThuLaoGiangDaySelectMethod

	#region ChiTienThuLaoGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTienThuLaoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTienThuLaoGiangDayFilter : SqlFilter<ChiTienThuLaoGiangDayColumn>
	{
	}
	
	#endregion ChiTienThuLaoGiangDayFilter

	#region ChiTienThuLaoGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTienThuLaoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTienThuLaoGiangDayExpressionBuilder : SqlExpressionBuilder<ChiTienThuLaoGiangDayColumn>
	{
	}
	
	#endregion ChiTienThuLaoGiangDayExpressionBuilder	

	#region ChiTienThuLaoGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ChiTienThuLaoGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ChiTienThuLaoGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChiTienThuLaoGiangDayProperty : ChildEntityProperty<ChiTienThuLaoGiangDayChildEntityTypes>
	{
	}
	
	#endregion ChiTienThuLaoGiangDayProperty
}

