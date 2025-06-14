const { contextBridge } = require('electron')
contextBridge.executeInMainWorld('Versions', {
    node: () => process.versions.node,
    chrome: () => process.versions.chrome,
    electron: () => process.versions.electron
})