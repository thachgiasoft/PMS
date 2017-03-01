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
	/// Represents the DataRepository.KyTinhLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KyTinhLuongDataSourceDesigner))]
	public class KyTinhLuongDataSource : ProviderDataSource<KyTinhLuong, KyTinhLuongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongDataSource class.
		/// </summary>
		public KyTinhLuongDataSource() : base(new KyTinhLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KyTinhLuongDataSourceView used by the KyTinhLuongDataSource.
		/// </summary>
		protected KyTinhLuongDataSourceView KyTinhLuongView
		{
			get { return ( View as KyTinhLuongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KyTinhLuongDataSource control invokes to retrieve data.
		/// </summary>
		public KyTinhLuongSelectMethod SelectMethod
		{
			get
			{
				KyTinhLuongSelectMethod selectMethod = KyTinhLuongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KyTinhLuongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KyTinhLuongDataSourceView class that is to be
		/// used by the KyTinhLuongDataSource.
		/// </summary>
		/// <returns>An instance of the KyTinhLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<KyTinhLuong, KyTinhLuongKey> GetNewDataSourceView()
		{
			return new KyTinhLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the KyTinhLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KyTinhLuongDataSourceView : ProviderDataSourceView<KyTinhLuong, KyTinhLuongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KyTinhLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KyTinhLuongDataSourceView(KyTinhLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KyTinhLuongDataSource KyTinhLuongOwner
		{
			get { return Owner as KyTinhLuongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KyTinhLuongSelectMethod SelectMethod
		{
			get { return KyTinhLuongOwner.SelectMethod; }
			set { KyTinhLuongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KyTinhLuongService KyTinhLuongProvider
		{
			get { return Provider as KyTinhLuongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KyTinhLuong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KyTinhLuong> results = null;
			KyTinhLuong item;
			count = 0;
			
			System.Int32 _id;
			System.String sp641_MaQuanLy;

			switch ( SelectMethod )
			{
				case KyTinhLuongSelectMethod.Get:
					KyTinhLuongKey entityKey  = new KyTinhLuongKey();
					entityKey.Load(values);
					item = KyTinhLuongProvider.Get(entityKey);
					results = new TList<KyTinhLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KyTinhLuongSelectMethod.GetAll:
                    results = KyTinhLuongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KyTinhLuongSelectMethod.GetPaged:
					results = KyTinhLuongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KyTinhLuongSelectMethod.Find:
					if ( FilterParameters != null )
						results = KyTinhLuongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KyTinhLuongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KyTinhLuongSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KyTinhLuongProvider.GetById(_id);
					results = new TList<KyTinhLuong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KyTinhLuongSelectMethod.GetByMaQuanLy:
					sp641_MaQuanLy = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					results = KyTinhLuongProvider.GetByMaQuanLy(sp641_MaQuanLy, StartIndex, PageSize);
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
			if ( SelectMethod == KyTinhLuongSelectMethod.Get || SelectMethod == KyTinhLuongSelectMethod.GetById )
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
				KyTinhLuong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KyTinhLuongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KyTinhLuong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KyTinhLuongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KyTinhLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KyTinhLuongDataSource class.
	/// </summary>
	public class KyTinhLuongDataSourceDesigner : ProviderDataSourceDesigner<KyTinhLuong, KyTinhLuongKey>
	{
		/// <summary>
		/// Initializes a new instance of the KyTinhLuongDataSourceDesigner class.
		/// </summary>
		public KyTinhLuongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KyTinhLuongSelectMethod SelectMethod
		{
			get { return ((KyTinhLuongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KyTinhLuongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KyTinhLuongDataSourceActionList

	/// <summary>
	/// Supports the KyTinhLuongDataSourceDesigner class.
	/// </summary>
	internal class KyTinhLuongDataSourceActionList : DesignerActionList
	{
		private KyTinhLuongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KyTinhLuongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KyTinhLuongDataSourceActionList(KyTinhLuongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KyTinhLuongSelectMethod SelectMethod
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

	#endregion KyTinhLuongDataSourceActionList
	
	#endregion KyTinhLuongDataSourceDesigner
	
	#region KyTinhLuongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KyTinhLuongDataSource.SelectMethod property.
	/// </summary>
	public enum KyTinhLuongSelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy
	}
	
	#endregion KyTinhLuongSelectMethod

	#region KyTinhLuongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyTinhLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyTinhLuongFilter : SqlFilter<KyTinhLuongColumn>
	{
	}
	
	#endregion KyTinhLuongFilter

	#region KyTinhLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KyTinhLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyTinhLuongExpressionBuilder : SqlExpressionBuilder<KyTinhLuongColumn>
	{
	}
	
	#endregion KyTinhLuongExpressionBuilder	

	#region KyTinhLuongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KyTinhLuongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KyTinhLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KyTinhLuongProperty : ChildEntityProperty<KyTinhLuongChildEntityTypes>
	{
	}
	
	#endregion KyTinhLuongProperty
}

