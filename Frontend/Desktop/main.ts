const { app, BrowserWindow } = require('electron/main')
const path = require('node:path')

let win : any = null

const createWindow = () => {
  win = new BrowserWindow({
    width: 800,
    height: 600,
    webPreferences: {
      preload: path.join(__dirname, 'preload.js')
    }
  })

  win.loadFile('./Pages/Login/login.html')
}

app.whenReady().then(() => {
  createWindow()

  app.on('activate', () => {
    if (BrowserWindow.getAllWindows().length === 0) {
      createWindow()
    }
  })
})

app.on('window-all-closed', () => {
  if (process.platform !== 'darwin') {
    app.quit()
  }
})

function LoadPage(sPageName : string){
  win.LoadPage(sPageName)
}

function CheckInput(sInput : string){
  if(sInput.length >= 1000){
    return true
  }

  if(sInput.includes("'") || sInput.includes('"')){
    return true
  }
}

