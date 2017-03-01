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
	/// Represents the DataRepository.DonGiaNgoaiQuyCheProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DonGiaNgoaiQuyCheDataSourceDesigner))]
	public class DonGiaNgoaiQuyCheDataSource : ProviderDataSource<DonGiaNgoaiQuyChe, DonGiaNgoaiQuyCheKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheDataSource class.
		/// </summary>
		public DonGiaNgoaiQuyCheDataSource() : base(new DonGiaNgoaiQuyCheService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DonGiaNgoaiQuyCheDataSourceView used by the DonGiaNgoaiQuyCheDataSource.
		/// </summary>
		protected DonGiaNgoaiQuyCheDataSourceView DonGiaNgoaiQuyCheView
		{
			get { return ( View as DonGiaNgoaiQuyCheDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DonGiaNgoaiQuyCheDataSource control invokes to retrieve data.
		/// </summary>
		public DonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get
			{
				DonGiaNgoaiQuyCheSelectMethod selectMethod = DonGiaNgoaiQuyCheSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DonGiaNgoaiQuyCheSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DonGiaNgoaiQuyCheDataSourceView class that is to be
		/// used by the DonGiaNgoaiQuyCheDataSource.
		/// </summary>
		/// <returns>An instance of the DonGiaNgoaiQuyCheDataSourceView class.</returns>
		protected override BaseDataSourceView<DonGiaNgoaiQuyChe, DonGiaNgoaiQuyCheKey> GetNewDataSourceView()
		{
			return new DonGiaNgoaiQuyCheDataSourceView(this, DefaultViewName);
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
	/// Supports the DonGiaNgoaiQuyCheDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DonGiaNgoaiQuyCheDataSourceView : ProviderDataSourceView<DonGiaNgoaiQuyChe, DonGiaNgoaiQuyCheKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DonGiaNgoaiQuyCheDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DonGiaNgoaiQuyCheDataSourceView(DonGiaNgoaiQuyCheDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DonGiaNgoaiQuyCheDataSource DonGiaNgoaiQuyCheOwner
		{
			get { return Owner as DonGiaNgoaiQuyCheDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get { return DonGiaNgoaiQuyCheOwner.SelectMethod; }
			set { DonGiaNgoaiQuyCheOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DonGiaNgoaiQuyCheService DonGiaNgoaiQuyCheProvider
		{
			get { return Provider as DonGiaNgoaiQuyCheService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DonGiaNgoaiQuyChe> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DonGiaNgoaiQuyChe> results = null;
			DonGiaNgoaiQuyChe item;
			count = 0;
			
			System.Int32 _id;
			System.Int32 sp82_MaGiangVien;
			System.DateTime sp82_NgayDay;

			switch ( SelectMethod )
			{
				case DonGiaNgoaiQuyCheSelectMethod.Get:
					DonGiaNgoaiQuyCheKey entityKey  = new DonGiaNgoaiQuyCheKey();
					entityKey.Load(values);
					item = DonGiaNgoaiQuyCheProvider.Get(entityKey);
					results = new TList<DonGiaNgoaiQuyChe>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DonGiaNgoaiQuyCheSelectMethod.GetAll:
                    results = DonGiaNgoaiQuyCheProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DonGiaNgoaiQuyCheSelectMethod.GetPaged:
					results = DonGiaNgoaiQuyCheProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DonGiaNgoaiQuyCheSelectMethod.Find:
					if ( FilterParameters != null )
						results = DonGiaNgoaiQuyCheProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DonGiaNgoaiQuyCheProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DonGiaNgoaiQuyCheSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DonGiaNgoaiQuyCheProvider.GetById(_id);
					results = new TList<DonGiaNgoaiQuyChe>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case DonGiaNgoaiQuyCheSelectMethod.GetByMaGiangVienNgayDay:
					sp82_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					sp82_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = DonGiaNgoaiQuyCheProvider.GetByMaGiangVienNgayDay(sp82_MaGiangVien, sp82_NgayDay, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == DonGiaNgoaiQuyCheSelectMethod.Get || SelectMethod == DonGiaNgoaiQuyCheSelectMethod.GetById )
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
				DonGiaNgoaiQuyChe entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DonGiaNgoaiQuyCheProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DonGiaNgoaiQuyChe> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DonGiaNgoaiQuyCheProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DonGiaNgoaiQuyCheDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DonGiaNgoaiQuyCheDataSource class.
	/// </summary>
	public class DonGiaNgoaiQuyCheDataSourceDesigner : ProviderDataSourceDesigner<DonGiaNgoaiQuyChe, DonGiaNgoaiQuyCheKey>
	{
		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheDataSourceDesigner class.
		/// </summary>
		public DonGiaNgoaiQuyCheDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaNgoaiQuyCheSelectMethod SelectMethod
		{
			get { return ((DonGiaNgoaiQuyCheDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DonGiaNgoaiQuyCheDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DonGiaNgoaiQuyCheDataSourceActionList

	/// <summary>
	/// Supports the DonGiaNgoaiQuyCheDataSourceDesigner class.
	/// </summary>
	internal class DonGiaNgoaiQuyCheDataSourceActionList : DesignerActionList
	{
		private DonGiaNgoaiQuyCheDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DonGiaNgoaiQuyCheDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DonGiaNgoaiQuyCheDataSourceActionList(DonGiaNgoaiQuyCheDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaNgoaiQuyCheSelectMethod SelectMethod
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

	#endregion DonGiaNgoaiQuyCheDataSourceActionList
	
	#endregion DonGiaNgoaiQuyCheDataSourceDesigner
	
	#region DonGiaNgoaiQuyCheSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DonGiaNgoaiQuyCheDataSource.SelectMethod property.
	/// </summary>
	public enum DonGiaNgoaiQuyCheSelectMethod
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
		GetById,
		/// <summary>
		/// Represents the GetByMaGiangVienNgayDay method.
		/// </summary>
		GetByMaGiangVienNgayDay
	}
	
	#endregion DonGiaNgoaiQuyCheSelectMethod

	#region DonGiaNgoaiQuyCheFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaNgoaiQuyCheFilter : SqlFilter<DonGiaNgoaiQuyCheColumn>
	{
	}
	
	#endregion DonGiaNgoaiQuyCheFilter

	#region DonGiaNgoaiQuyCheExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaNgoaiQuyCheExpressionBuilder : SqlExpressionBuilder<DonGiaNgoaiQuyCheColumn>
	{
	}
	
	#endregion DonGiaNgoaiQuyCheExpressionBuilder	

	#region DonGiaNgoaiQuyCheProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DonGiaNgoaiQuyCheChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaNgoaiQuyChe"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaNgoaiQuyCheProperty : ChildEntityProperty<DonGiaNgoaiQuyCheChildEntityTypes>
	{
	}
	
	#endregion DonGiaNgoaiQuyCheProperty
}

