## 專案說明
這是一個預設範本的 MVC5 專案。 在 RouteConfig 新增一個自訂路由，自訂類別為 CmsUrlConstraint，該自訂路由會呼叫 async 的方法，結果造成死結。

**此專案會在 LocalDB 建立一個資料庫**
LocalDB 連線字串: `(localdb)\MSSQLLocalDB`
DB 名稱: `TestIRouteConstraint.Models.ProductContext`

## 進入死結點方式
網址輸入 http://localhost:52572/market

## 中斷點位置
CmsUrlConstraint.cs

## ChildAction 無法使用 async/await 的解法位置
https://justsimplycode.com/2016/09/04/child-action-in-mvc-5-does-not-support-async/
HomeController.TestChild()