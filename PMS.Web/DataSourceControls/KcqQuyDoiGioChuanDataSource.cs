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
	/// Represents the DataRepository.KcqQuyDoiGioChuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqQuyDoiGioChuanDataSourceDesigner))]
	public class KcqQuyDoiGioChuanDataSource : ProviderDataSource<KcqQuyDoiGioChuan, KcqQuyDoiGioChuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanDataSource class.
		/// </summary>
		public KcqQuyDoiGioChuanDataSource() : base(new KcqQuyDoiGioChuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqQuyDoiGioChuanDataSourceView used by the KcqQuyDoiGioChuanDataSource.
		/// </summary>
		protected KcqQuyDoiGioChuanDataSourceView KcqQuyDoiGioChuanView
		{
			get { return ( View as KcqQuyDoiGioChuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqQuyDoiGioChuanDataSource control invokes to retrieve data.
		/// </summary>
		public KcqQuyDoiGioChuanSelectMethod SelectMethod
		{
			get
			{
				KcqQuyDoiGioChuanSelectMethod selectMethod = KcqQuyDoiGioChuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqQuyDoiGioChuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqQuyDoiGioChuanDataSourceView class that is to be
		/// used by the KcqQuyDoiGioChuanDataSource.
		/// </summary>
		/// <returns>An instance of the KcqQuyDoiGioChuanDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqQuyDoiGioChuan, KcqQuyDoiGioChuanKey> GetNewDataSourceView()
		{
			return new KcqQuyDoiGioChuanDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqQuyDoiGioChuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqQuyDoiGioChuanDataSourceView : ProviderDataSourceView<KcqQuyDoiGioChuan, KcqQuyDoiGioChuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqQuyDoiGioChuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqQuyDoiGioChuanDataSourceView(KcqQuyDoiGioChuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqQuyDoiGioChuanDataSource KcqQuyDoiGioChuanOwner
		{
			get { return Owner as KcqQuyDoiGioChuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqQuyDoiGioChuanSelectMethod SelectMethod
		{
			get { return KcqQuyDoiGioChuanOwner.SelectMethod; }
			set { KcqQuyDoiGioChuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqQuyDoiGioChuanService KcqQuyDoiGioChuanProvider
		{
			get { return Provider as KcqQuyDoiGioChuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqQuyDoiGioChuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqQuyDoiGioChuan> results = null;
			KcqQuyDoiGioChuan item;
			count = 0;
			
			System.Int32 _maQuyDoi;
			System.Int32? _maDonVi_nullable;

			switch ( SelectMethod )
			{
				case KcqQuyDoiGioChuanSelectMethod.Get:
					KcqQuyDoiGioChuanKey entityKey  = new KcqQuyDoiGioChuanKey();
					entityKey.Load(values);
					item = KcqQuyDoiGioChuanProvider.Get(entityKey);
					results = new TList<KcqQuyDoiGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqQuyDoiGioChuanSelectMethod.GetAll:
                    results = KcqQuyDoiGioChuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqQuyDoiGioChuanSelectMethod.GetPaged:
					results = KcqQuyDoiGioChuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqQuyDoiGioChuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqQuyDoiGioChuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqQuyDoiGioChuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqQuyDoiGioChuanSelectMethod.GetByMaQuyDoi:
					_maQuyDoi = ( values["MaQuyDoi"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuyDoi"], typeof(System.Int32)) : (int)0;
					item = KcqQuyDoiGioChuanProvider.GetByMaQuyDoi(_maQuyDoi);
					results = new TList<KcqQuyDoiGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KcqQuyDoiGioChuanSelectMethod.GetByMaDonVi:
					_maDonVi_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.Int32?));
					results = KcqQuyDoiGioChuanProvider.GetByMaDonVi(_maDonVi_nullable, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == KcqQuyDoiGioChuanSelectMethod.Get || SelectMethod == KcqQuyDoiGioChuanSelectMethod.GetByMaQuyDoi )
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
				KcqQuyDoiGioChuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqQuyDoiGioChuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqQuyDoiGioChuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqQuyDoiGioChuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqQuyDoiGioChuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqQuyDoiGioChuanDataSource class.
	/// </summary>
	public class KcqQuyDoiGioChuanDataSourceDesigner : ProviderDataSourceDesigner<KcqQuyDoiGioChuan, KcqQuyDoiGioChuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanDataSourceDesigner class.
		/// </summary>
		public KcqQuyDoiGioChuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqQuyDoiGioChuanSelectMethod SelectMethod
		{
			get { return ((KcqQuyDoiGioChuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqQuyDoiGioChuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqQuyDoiGioChuanDataSourceActionList

	/// <summary>
	/// Supports the KcqQuyDoiGioChuanDataSourceDesigner class.
	/// </summary>
	internal class KcqQuyDoiGioChuanDataSourceActionList : DesignerActionList
	{
		private KcqQuyDoiGioChuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqQuyDoiGioChuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqQuyDoiGioChuanDataSourceActionList(KcqQuyDoiGioChuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqQuyDoiGioChuanSelectMethod SelectMethod
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

	#endregion KcqQuyDoiGioChuanDataSourceActionList
	
	#endregion KcqQuyDoiGioChuanDataSourceDesigner
	
	#region KcqQuyDoiGioChuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqQuyDoiGioChuanDataSource.SelectMethod property.
	/// </summary>
	public enum KcqQuyDoiGioChuanSelectMethod
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
		/// Represents the GetByMaQuyDoi method.
		/// </summary>
		GetByMaQuyDoi,
		/// <summary>
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi
	}
	
	#endregion KcqQuyDoiGioChuanSelectMethod

	#region KcqQuyDoiGioChuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqQuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqQuyDoiGioChuanFilter : SqlFilter<KcqQuyDoiGioChuanColumn>
	{
	}
	
	#endregion KcqQuyDoiGioChuanFilter

	#region KcqQuyDoiGioChuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqQuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqQuyDoiGioChuanExpressionBuilder : SqlExpressionBuilder<KcqQuyDoiGioChuanColumn>
	{
	}
	
	#endregion KcqQuyDoiGioChuanExpressionBuilder	

	#region KcqQuyDoiGioChuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqQuyDoiGioChuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqQuyDoiGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqQuyDoiGioChuanProperty : ChildEntityProperty<KcqQuyDoiGioChuanChildEntityTypes>
	{
	}
	
	#endregion KcqQuyDoiGioChuanProperty
}

