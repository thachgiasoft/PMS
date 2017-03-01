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
	/// Represents the DataRepository.KcqMonTieuLuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqMonTieuLuanDataSourceDesigner))]
	public class KcqMonTieuLuanDataSource : ProviderDataSource<KcqMonTieuLuan, KcqMonTieuLuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonTieuLuanDataSource class.
		/// </summary>
		public KcqMonTieuLuanDataSource() : base(new KcqMonTieuLuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqMonTieuLuanDataSourceView used by the KcqMonTieuLuanDataSource.
		/// </summary>
		protected KcqMonTieuLuanDataSourceView KcqMonTieuLuanView
		{
			get { return ( View as KcqMonTieuLuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqMonTieuLuanDataSource control invokes to retrieve data.
		/// </summary>
		public KcqMonTieuLuanSelectMethod SelectMethod
		{
			get
			{
				KcqMonTieuLuanSelectMethod selectMethod = KcqMonTieuLuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqMonTieuLuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqMonTieuLuanDataSourceView class that is to be
		/// used by the KcqMonTieuLuanDataSource.
		/// </summary>
		/// <returns>An instance of the KcqMonTieuLuanDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqMonTieuLuan, KcqMonTieuLuanKey> GetNewDataSourceView()
		{
			return new KcqMonTieuLuanDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqMonTieuLuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqMonTieuLuanDataSourceView : ProviderDataSourceView<KcqMonTieuLuan, KcqMonTieuLuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonTieuLuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqMonTieuLuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqMonTieuLuanDataSourceView(KcqMonTieuLuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqMonTieuLuanDataSource KcqMonTieuLuanOwner
		{
			get { return Owner as KcqMonTieuLuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqMonTieuLuanSelectMethod SelectMethod
		{
			get { return KcqMonTieuLuanOwner.SelectMethod; }
			set { KcqMonTieuLuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqMonTieuLuanService KcqMonTieuLuanProvider
		{
			get { return Provider as KcqMonTieuLuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqMonTieuLuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqMonTieuLuan> results = null;
			KcqMonTieuLuan item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2482_NamHoc;
			System.String sp2482_HocKy;

			switch ( SelectMethod )
			{
				case KcqMonTieuLuanSelectMethod.Get:
					KcqMonTieuLuanKey entityKey  = new KcqMonTieuLuanKey();
					entityKey.Load(values);
					item = KcqMonTieuLuanProvider.Get(entityKey);
					results = new TList<KcqMonTieuLuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqMonTieuLuanSelectMethod.GetAll:
                    results = KcqMonTieuLuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqMonTieuLuanSelectMethod.GetPaged:
					results = KcqMonTieuLuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqMonTieuLuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqMonTieuLuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqMonTieuLuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqMonTieuLuanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqMonTieuLuanProvider.GetById(_id);
					results = new TList<KcqMonTieuLuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KcqMonTieuLuanSelectMethod.GetByNamHocHocKy:
					sp2482_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2482_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KcqMonTieuLuanProvider.GetByNamHocHocKy(sp2482_NamHoc, sp2482_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == KcqMonTieuLuanSelectMethod.Get || SelectMethod == KcqMonTieuLuanSelectMethod.GetById )
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
				KcqMonTieuLuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqMonTieuLuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqMonTieuLuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqMonTieuLuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqMonTieuLuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqMonTieuLuanDataSource class.
	/// </summary>
	public class KcqMonTieuLuanDataSourceDesigner : ProviderDataSourceDesigner<KcqMonTieuLuan, KcqMonTieuLuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqMonTieuLuanDataSourceDesigner class.
		/// </summary>
		public KcqMonTieuLuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonTieuLuanSelectMethod SelectMethod
		{
			get { return ((KcqMonTieuLuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqMonTieuLuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqMonTieuLuanDataSourceActionList

	/// <summary>
	/// Supports the KcqMonTieuLuanDataSourceDesigner class.
	/// </summary>
	internal class KcqMonTieuLuanDataSourceActionList : DesignerActionList
	{
		private KcqMonTieuLuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqMonTieuLuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqMonTieuLuanDataSourceActionList(KcqMonTieuLuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonTieuLuanSelectMethod SelectMethod
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

	#endregion KcqMonTieuLuanDataSourceActionList
	
	#endregion KcqMonTieuLuanDataSourceDesigner
	
	#region KcqMonTieuLuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqMonTieuLuanDataSource.SelectMethod property.
	/// </summary>
	public enum KcqMonTieuLuanSelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion KcqMonTieuLuanSelectMethod

	#region KcqMonTieuLuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonTieuLuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonTieuLuanFilter : SqlFilter<KcqMonTieuLuanColumn>
	{
	}
	
	#endregion KcqMonTieuLuanFilter

	#region KcqMonTieuLuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonTieuLuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonTieuLuanExpressionBuilder : SqlExpressionBuilder<KcqMonTieuLuanColumn>
	{
	}
	
	#endregion KcqMonTieuLuanExpressionBuilder	

	#region KcqMonTieuLuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqMonTieuLuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonTieuLuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonTieuLuanProperty : ChildEntityProperty<KcqMonTieuLuanChildEntityTypes>
	{
	}
	
	#endregion KcqMonTieuLuanProperty
}

