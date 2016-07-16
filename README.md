# scylla-todo
A work in progress. 

Eventually a simple bare bones todo app backed with a scylla persistence layer.

## Getting Started (on Mac)

1. Check out the repository onto your machine.
1. Install [VirtualBox 5.0](http://download.virtualbox.org/virtualbox/5.0.24/VirtualBox-5.0.24-108355-OSX.dmg). 
    * NOTE: Vagrant does not currently support VirtualBox 5.1! 
    * Check [here](https://www.vagrantup.com/docs/virtualbox/) for supported virtual box providers.
1. Install [VS Code](https://code.visualstudio.com/Download).
1. Install [Vagrant](https://www.vagrantup.com/downloads.html).
1. Install [Ansible](http://docs.ansible.com/ansible/intro_installation.html#latest-releases-via-pip).
1. Install VS Code Extensions and set up .Net Core:
    1. Open VS Code
    1. Find the extension icon on the leftmost navigation bar
    1. Search for "C#" and install
    1. Install .Net Core (See [the .Net Core Getting Started Guide](https://www.microsoft.com/net/core#macos) for more info)
        1. Install [Homebrew](http://brew.sh/)
        1. Update & Install prerequisites: 
           * run `$ brew update`
           * run `$ brew install openssl`
           * run `$ brew link --force openssl`
        1. Download and install the official [.Net Core Installer](https://go.microsoft.com/fwlink/?LinkID=809124)
1. Install Vagrant Box: 
    1. run `$ cd ./path/to/where/you/checked/out/the/repository`
    1. run `$ sudo vagrant box add puppetlabs/centos-7.2-64-nocm --provider virtualbox`
1. Make sure your setuptools are up to date:
    1. run `pip install --upgrade setuptools --user python`
1. Bring up your environment: 
    1. run `$sudo vagrant up`

