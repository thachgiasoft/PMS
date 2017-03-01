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
	/// Represents the DataRepository.KhoiLuongQuyDoiCaoDangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongQuyDoiCaoDangDataSourceDesigner))]
	public class KhoiLuongQuyDoiCaoDangDataSource : ProviderDataSource<KhoiLuongQuyDoiCaoDang, KhoiLuongQuyDoiCaoDangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangDataSource class.
		/// </summary>
		public KhoiLuongQuyDoiCaoDangDataSource() : base(new KhoiLuongQuyDoiCaoDangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongQuyDoiCaoDangDataSourceView used by the KhoiLuongQuyDoiCaoDangDataSource.
		/// </summary>
		protected KhoiLuongQuyDoiCaoDangDataSourceView KhoiLuongQuyDoiCaoDangView
		{
			get { return ( View as KhoiLuongQuyDoiCaoDangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongQuyDoiCaoDangDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongQuyDoiCaoDangSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongQuyDoiCaoDangSelectMethod selectMethod = KhoiLuongQuyDoiCaoDangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongQuyDoiCaoDangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongQuyDoiCaoDangDataSourceView class that is to be
		/// used by the KhoiLuongQuyDoiCaoDangDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongQuyDoiCaoDangDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongQuyDoiCaoDang, KhoiLuongQuyDoiCaoDangKey> GetNewDataSourceView()
		{
			return new KhoiLuongQuyDoiCaoDangDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongQuyDoiCaoDangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongQuyDoiCaoDangDataSourceView : ProviderDataSourceView<KhoiLuongQuyDoiCaoDang, KhoiLuongQuyDoiCaoDangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongQuyDoiCaoDangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongQuyDoiCaoDangDataSourceView(KhoiLuongQuyDoiCaoDangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongQuyDoiCaoDangDataSource KhoiLuongQuyDoiCaoDangOwner
		{
			get { return Owner as KhoiLuongQuyDoiCaoDangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongQuyDoiCaoDangSelectMethod SelectMethod
		{
			get { return KhoiLuongQuyDoiCaoDangOwner.SelectMethod; }
			set { KhoiLuongQuyDoiCaoDangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongQuyDoiCaoDangService KhoiLuongQuyDoiCaoDangProvider
		{
			get { return Provider as KhoiLuongQuyDoiCaoDangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongQuyDoiCaoDang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongQuyDoiCaoDang> results = null;
			KhoiLuongQuyDoiCaoDang item;
			count = 0;
			
			System.Int32 _maKhoiLuongQuyDoiCaoDang;
			System.Int32? _maKhoiLuongCaoDang_nullable;

			switch ( SelectMethod )
			{
				case KhoiLuongQuyDoiCaoDangSelectMethod.Get:
					KhoiLuongQuyDoiCaoDangKey entityKey  = new KhoiLuongQuyDoiCaoDangKey();
					entityKey.Load(values);
					item = KhoiLuongQuyDoiCaoDangProvider.Get(entityKey);
					results = new TList<KhoiLuongQuyDoiCaoDang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongQuyDoiCaoDangSelectMethod.GetAll:
                    results = KhoiLuongQuyDoiCaoDangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongQuyDoiCaoDangSelectMethod.GetPaged:
					results = KhoiLuongQuyDoiCaoDangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongQuyDoiCaoDangSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongQuyDoiCaoDangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongQuyDoiCaoDangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongQuyDoiCaoDangSelectMethod.GetByMaKhoiLuongQuyDoiCaoDang:
					_maKhoiLuongQuyDoiCaoDang = ( values["MaKhoiLuongQuyDoiCaoDang"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuongQuyDoiCaoDang"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongQuyDoiCaoDangProvider.GetByMaKhoiLuongQuyDoiCaoDang(_maKhoiLuongQuyDoiCaoDang);
					results = new TList<KhoiLuongQuyDoiCaoDang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KhoiLuongQuyDoiCaoDangSelectMethod.GetByMaKhoiLuongCaoDang:
					_maKhoiLuongCaoDang_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaKhoiLuongCaoDang"], typeof(System.Int32?));
					results = KhoiLuongQuyDoiCaoDangProvider.GetByMaKhoiLuongCaoDang(_maKhoiLuongCaoDang_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == KhoiLuongQuyDoiCaoDangSelectMethod.Get || SelectMethod == KhoiLuongQuyDoiCaoDangSelectMethod.GetByMaKhoiLuongQuyDoiCaoDang )
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
				KhoiLuongQuyDoiCaoDang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongQuyDoiCaoDangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongQuyDoiCaoDang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongQuyDoiCaoDangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongQuyDoiCaoDangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongQuyDoiCaoDangDataSource class.
	/// </summary>
	public class KhoiLuongQuyDoiCaoDangDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongQuyDoiCaoDang, KhoiLuongQuyDoiCaoDangKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangDataSourceDesigner class.
		/// </summary>
		public KhoiLuongQuyDoiCaoDangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongQuyDoiCaoDangSelectMethod SelectMethod
		{
			get { return ((KhoiLuongQuyDoiCaoDangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongQuyDoiCaoDangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongQuyDoiCaoDangDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongQuyDoiCaoDangDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongQuyDoiCaoDangDataSourceActionList : DesignerActionList
	{
		private KhoiLuongQuyDoiCaoDangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiCaoDangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongQuyDoiCaoDangDataSourceActionList(KhoiLuongQuyDoiCaoDangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongQuyDoiCaoDangSelectMethod SelectMethod
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

	#endregion KhoiLuongQuyDoiCaoDangDataSourceActionList
	
	#endregion KhoiLuongQuyDoiCaoDangDataSourceDesigner
	
	#region KhoiLuongQuyDoiCaoDangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongQuyDoiCaoDangDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongQuyDoiCaoDangSelectMethod
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
		/// Represents the GetByMaKhoiLuongQuyDoiCaoDang method.
		/// </summary>
		GetByMaKhoiLuongQuyDoiCaoDang,
		/// <summary>
		/// Represents the GetByMaKhoiLuongCaoDang method.
		/// </summary>
		GetByMaKhoiLuongCaoDang
	}
	
	#endregion KhoiLuongQuyDoiCaoDangSelectMethod

	#region KhoiLuongQuyDoiCaoDangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoiCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiCaoDangFilter : SqlFilter<KhoiLuongQuyDoiCaoDangColumn>
	{
	}
	
	#endregion KhoiLuongQuyDoiCaoDangFilter

	#region KhoiLuongQuyDoiCaoDangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoiCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiCaoDangExpressionBuilder : SqlExpressionBuilder<KhoiLuongQuyDoiCaoDangColumn>
	{
	}
	
	#endregion KhoiLuongQuyDoiCaoDangExpressionBuilder	

	#region KhoiLuongQuyDoiCaoDangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongQuyDoiCaoDangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoiCaoDang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiCaoDangProperty : ChildEntityProperty<KhoiLuongQuyDoiCaoDangChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongQuyDoiCaoDangProperty
}

