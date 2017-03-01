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
	/// Represents the DataRepository.KcqDonGiaProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqDonGiaDataSourceDesigner))]
	public class KcqDonGiaDataSource : ProviderDataSource<KcqDonGia, KcqDonGiaKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaDataSource class.
		/// </summary>
		public KcqDonGiaDataSource() : base(new KcqDonGiaService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqDonGiaDataSourceView used by the KcqDonGiaDataSource.
		/// </summary>
		protected KcqDonGiaDataSourceView KcqDonGiaView
		{
			get { return ( View as KcqDonGiaDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqDonGiaDataSource control invokes to retrieve data.
		/// </summary>
		public KcqDonGiaSelectMethod SelectMethod
		{
			get
			{
				KcqDonGiaSelectMethod selectMethod = KcqDonGiaSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqDonGiaSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqDonGiaDataSourceView class that is to be
		/// used by the KcqDonGiaDataSource.
		/// </summary>
		/// <returns>An instance of the KcqDonGiaDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqDonGia, KcqDonGiaKey> GetNewDataSourceView()
		{
			return new KcqDonGiaDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqDonGiaDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqDonGiaDataSourceView : ProviderDataSourceView<KcqDonGia, KcqDonGiaKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqDonGiaDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqDonGiaDataSourceView(KcqDonGiaDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqDonGiaDataSource KcqDonGiaOwner
		{
			get { return Owner as KcqDonGiaDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqDonGiaSelectMethod SelectMethod
		{
			get { return KcqDonGiaOwner.SelectMethod; }
			set { KcqDonGiaOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqDonGiaService KcqDonGiaProvider
		{
			get { return Provider as KcqDonGiaService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqDonGia> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqDonGia> results = null;
			KcqDonGia item;
			count = 0;
			
			System.Int32 _id;
			System.Int32 sp2450_MaHinhThucDaoTao;

			switch ( SelectMethod )
			{
				case KcqDonGiaSelectMethod.Get:
					KcqDonGiaKey entityKey  = new KcqDonGiaKey();
					entityKey.Load(values);
					item = KcqDonGiaProvider.Get(entityKey);
					results = new TList<KcqDonGia>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqDonGiaSelectMethod.GetAll:
                    results = KcqDonGiaProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqDonGiaSelectMethod.GetPaged:
					results = KcqDonGiaProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqDonGiaSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqDonGiaProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqDonGiaProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqDonGiaSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqDonGiaProvider.GetById(_id);
					results = new TList<KcqDonGia>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KcqDonGiaSelectMethod.GetByHinhThucDaoTao:
					sp2450_MaHinhThucDaoTao = (System.Int32) EntityUtil.ChangeType(values["MaHinhThucDaoTao"], typeof(System.Int32));
					results = KcqDonGiaProvider.GetByHinhThucDaoTao(sp2450_MaHinhThucDaoTao, StartIndex, PageSize);
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
			if ( SelectMethod == KcqDonGiaSelectMethod.Get || SelectMethod == KcqDonGiaSelectMethod.GetById )
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
				KcqDonGia entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqDonGiaProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqDonGia> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqDonGiaProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqDonGiaDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqDonGiaDataSource class.
	/// </summary>
	public class KcqDonGiaDataSourceDesigner : ProviderDataSourceDesigner<KcqDonGia, KcqDonGiaKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqDonGiaDataSourceDesigner class.
		/// </summary>
		public KcqDonGiaDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqDonGiaSelectMethod SelectMethod
		{
			get { return ((KcqDonGiaDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqDonGiaDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqDonGiaDataSourceActionList

	/// <summary>
	/// Supports the KcqDonGiaDataSourceDesigner class.
	/// </summary>
	internal class KcqDonGiaDataSourceActionList : DesignerActionList
	{
		private KcqDonGiaDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqDonGiaDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqDonGiaDataSourceActionList(KcqDonGiaDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqDonGiaSelectMethod SelectMethod
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

	#endregion KcqDonGiaDataSourceActionList
	
	#endregion KcqDonGiaDataSourceDesigner
	
	#region KcqDonGiaSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqDonGiaDataSource.SelectMethod property.
	/// </summary>
	public enum KcqDonGiaSelectMethod
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
		/// Represents the GetByHinhThucDaoTao method.
		/// </summary>
		GetByHinhThucDaoTao
	}
	
	#endregion KcqDonGiaSelectMethod

	#region KcqDonGiaFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqDonGiaFilter : SqlFilter<KcqDonGiaColumn>
	{
	}
	
	#endregion KcqDonGiaFilter

	#region KcqDonGiaExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqDonGiaExpressionBuilder : SqlExpressionBuilder<KcqDonGiaColumn>
	{
	}
	
	#endregion KcqDonGiaExpressionBuilder	

	#region KcqDonGiaProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqDonGiaChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqDonGia"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqDonGiaProperty : ChildEntityProperty<KcqDonGiaChildEntityTypes>
	{
	}
	
	#endregion KcqDonGiaProperty
}

