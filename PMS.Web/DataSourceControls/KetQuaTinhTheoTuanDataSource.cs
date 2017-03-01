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
	/// Represents the DataRepository.KetQuaTinhTheoTuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KetQuaTinhTheoTuanDataSourceDesigner))]
	public class KetQuaTinhTheoTuanDataSource : ProviderDataSource<KetQuaTinhTheoTuan, KetQuaTinhTheoTuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanDataSource class.
		/// </summary>
		public KetQuaTinhTheoTuanDataSource() : base(new KetQuaTinhTheoTuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KetQuaTinhTheoTuanDataSourceView used by the KetQuaTinhTheoTuanDataSource.
		/// </summary>
		protected KetQuaTinhTheoTuanDataSourceView KetQuaTinhTheoTuanView
		{
			get { return ( View as KetQuaTinhTheoTuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KetQuaTinhTheoTuanDataSource control invokes to retrieve data.
		/// </summary>
		public KetQuaTinhTheoTuanSelectMethod SelectMethod
		{
			get
			{
				KetQuaTinhTheoTuanSelectMethod selectMethod = KetQuaTinhTheoTuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KetQuaTinhTheoTuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KetQuaTinhTheoTuanDataSourceView class that is to be
		/// used by the KetQuaTinhTheoTuanDataSource.
		/// </summary>
		/// <returns>An instance of the KetQuaTinhTheoTuanDataSourceView class.</returns>
		protected override BaseDataSourceView<KetQuaTinhTheoTuan, KetQuaTinhTheoTuanKey> GetNewDataSourceView()
		{
			return new KetQuaTinhTheoTuanDataSourceView(this, DefaultViewName);
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
	/// Supports the KetQuaTinhTheoTuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KetQuaTinhTheoTuanDataSourceView : ProviderDataSourceView<KetQuaTinhTheoTuan, KetQuaTinhTheoTuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KetQuaTinhTheoTuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KetQuaTinhTheoTuanDataSourceView(KetQuaTinhTheoTuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KetQuaTinhTheoTuanDataSource KetQuaTinhTheoTuanOwner
		{
			get { return Owner as KetQuaTinhTheoTuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KetQuaTinhTheoTuanSelectMethod SelectMethod
		{
			get { return KetQuaTinhTheoTuanOwner.SelectMethod; }
			set { KetQuaTinhTheoTuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KetQuaTinhTheoTuanService KetQuaTinhTheoTuanProvider
		{
			get { return Provider as KetQuaTinhTheoTuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KetQuaTinhTheoTuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KetQuaTinhTheoTuan> results = null;
			KetQuaTinhTheoTuan item;
			count = 0;
			
			System.Int32 _maKetQua;

			switch ( SelectMethod )
			{
				case KetQuaTinhTheoTuanSelectMethod.Get:
					KetQuaTinhTheoTuanKey entityKey  = new KetQuaTinhTheoTuanKey();
					entityKey.Load(values);
					item = KetQuaTinhTheoTuanProvider.Get(entityKey);
					results = new TList<KetQuaTinhTheoTuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KetQuaTinhTheoTuanSelectMethod.GetAll:
                    results = KetQuaTinhTheoTuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KetQuaTinhTheoTuanSelectMethod.GetPaged:
					results = KetQuaTinhTheoTuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KetQuaTinhTheoTuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = KetQuaTinhTheoTuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KetQuaTinhTheoTuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KetQuaTinhTheoTuanSelectMethod.GetByMaKetQua:
					_maKetQua = ( values["MaKetQua"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKetQua"], typeof(System.Int32)) : (int)0;
					item = KetQuaTinhTheoTuanProvider.GetByMaKetQua(_maKetQua);
					results = new TList<KetQuaTinhTheoTuan>();
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
			if ( SelectMethod == KetQuaTinhTheoTuanSelectMethod.Get || SelectMethod == KetQuaTinhTheoTuanSelectMethod.GetByMaKetQua )
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
				KetQuaTinhTheoTuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KetQuaTinhTheoTuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KetQuaTinhTheoTuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KetQuaTinhTheoTuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KetQuaTinhTheoTuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KetQuaTinhTheoTuanDataSource class.
	/// </summary>
	public class KetQuaTinhTheoTuanDataSourceDesigner : ProviderDataSourceDesigner<KetQuaTinhTheoTuan, KetQuaTinhTheoTuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanDataSourceDesigner class.
		/// </summary>
		public KetQuaTinhTheoTuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaTinhTheoTuanSelectMethod SelectMethod
		{
			get { return ((KetQuaTinhTheoTuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KetQuaTinhTheoTuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KetQuaTinhTheoTuanDataSourceActionList

	/// <summary>
	/// Supports the KetQuaTinhTheoTuanDataSourceDesigner class.
	/// </summary>
	internal class KetQuaTinhTheoTuanDataSourceActionList : DesignerActionList
	{
		private KetQuaTinhTheoTuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KetQuaTinhTheoTuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KetQuaTinhTheoTuanDataSourceActionList(KetQuaTinhTheoTuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KetQuaTinhTheoTuanSelectMethod SelectMethod
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

	#endregion KetQuaTinhTheoTuanDataSourceActionList
	
	#endregion KetQuaTinhTheoTuanDataSourceDesigner
	
	#region KetQuaTinhTheoTuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KetQuaTinhTheoTuanDataSource.SelectMethod property.
	/// </summary>
	public enum KetQuaTinhTheoTuanSelectMethod
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
		/// Represents the GetByMaKetQua method.
		/// </summary>
		GetByMaKetQua
	}
	
	#endregion KetQuaTinhTheoTuanSelectMethod

	#region KetQuaTinhTheoTuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinhTheoTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhTheoTuanFilter : SqlFilter<KetQuaTinhTheoTuanColumn>
	{
	}
	
	#endregion KetQuaTinhTheoTuanFilter

	#region KetQuaTinhTheoTuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinhTheoTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhTheoTuanExpressionBuilder : SqlExpressionBuilder<KetQuaTinhTheoTuanColumn>
	{
	}
	
	#endregion KetQuaTinhTheoTuanExpressionBuilder	

	#region KetQuaTinhTheoTuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KetQuaTinhTheoTuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KetQuaTinhTheoTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KetQuaTinhTheoTuanProperty : ChildEntityProperty<KetQuaTinhTheoTuanChildEntityTypes>
	{
	}
	
	#endregion KetQuaTinhTheoTuanProperty
}

